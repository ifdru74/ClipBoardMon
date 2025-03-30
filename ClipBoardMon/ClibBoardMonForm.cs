using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClipBoardMon
{
    public partial class frmMain : Form
    {
        bool bSave;
        [DllImport("User32.dll")]
        protected static extern int
                    SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool
                ChangeClipboardChain(IntPtr hWndRemove,
                                     IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg,
                                             IntPtr wParam,
                                             IntPtr lParam);
        IntPtr nextClipboardViewer;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);


        // ID for the About item on the system menu
        private int SYSMENU_ABOUT_ID = 0x1;
        private const int WM_SYSCOMMAND = 0x112;
        private const int MF_STRING = 0x0;
        private const int MF_SEPARATOR = 0x800;

        public frmMain()
        {
            InitializeComponent();
            bSave = false;
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)
                                     this.Handle);
        }
        protected override void
                  WndProc(ref System.Windows.Forms.Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if(Clipboard.ContainsImage() && bSave)
                    {
                        Image bmp = Clipboard.GetImage();
                        DateTime dt = DateTime.Now;
                        string fileName = dt.ToString("yyyy-MM-dd_HH-mm-ss-ffff") + ".png";
                        addFileName(fileName);
                        bmp.Save(Properties.Settings.Default.SaveDirectory + fileName);
                    }
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam,
                                m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam,
                                    m.LParam);
                    break;
                case WM_SYSCOMMAND:
                    if((int)m.WParam == SYSMENU_ABOUT_ID)
                    {
                        AboutBox1 ab = new AboutBox1();
                        ab.ShowDialog();
                    }
                    else
                    {
                        base.WndProc(ref m);
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string sPath = txtDir.Text;
            if (sPath.Length>0)
            {
                if (sPath.Length - sPath.LastIndexOf('\\') > 1)
                {
                    sPath += '\\';
                    txtDir.Text = sPath;
                }
                Properties.Settings.Default.SaveDirectory = txtDir.Text;
                Properties.Settings.Default.Save();
                bSave = true;
                btnStop.Enabled = bSave;
                btnStart.Enabled = !bSave;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bSave = false;
            btnStop.Enabled = bSave;
            btnStart.Enabled = !bSave;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop_Click(null, null);
            Properties.Settings.Default.SaveDirectory = txtDir.Text;
            Properties.Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDir.Text = Properties.Settings.Default.SaveDirectory;
            txtDir_TextChanged(sender, e);
            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);

            // Add a separator
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, string.Empty);

            // Add the About menu item
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "&About…");
            this.Icon = Properties.Resources.statusnormal_ico;
        }
        private void addFileName(string fileName)
        {
            fileListBox.Items.Insert(0, fileName);
            while(fileListBox.Items.Count>100)
            {
                fileListBox.Items.RemoveAt(fileListBox.Items.Count-1);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void clearListItem_Click(object sender, EventArgs e)
        {
            fileListBox.Items.Clear();
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            btnExplorer.Enabled = btnStart.Enabled = (txtDir.Text.Length > 0);
        }

        private void btnExplorer_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(txtDir.Text);
    }
}
