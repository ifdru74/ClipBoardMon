namespace ClipBoardMon
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.clearList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.clearList.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtDir
            // 
            this.txtDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            resources.ApplyResources(this.txtDir, "txtDir");
            this.txtDir.Name = "txtDir";
            this.mainToolTip.SetToolTip(this.txtDir, resources.GetString("txtDir.ToolTip"));
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            // 
            // fileListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fileListBox, 2);
            this.fileListBox.ContextMenuStrip = this.clearList;
            resources.ApplyResources(this.fileListBox, "fileListBox");
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Name = "fileListBox";
            this.mainToolTip.SetToolTip(this.fileListBox, resources.GetString("fileListBox.ToolTip"));
            // 
            // clearList
            // 
            this.clearList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clearList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListItem});
            this.clearList.Name = "clearList";
            resources.ApplyResources(this.clearList, "clearList");
            this.clearList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clearListItem
            // 
            this.clearListItem.Name = "clearListItem";
            resources.ApplyResources(this.clearListItem, "clearListItem");
            this.clearListItem.Click += new System.EventHandler(this.clearListItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Controls.Add(this.btnStop);
            this.flowLayoutPanel1.Controls.Add(this.btnExplorer);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.mainToolTip.SetToolTip(this.btnStart, resources.GetString("btnStart.ToolTip"));
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.mainToolTip.SetToolTip(this.btnStop, resources.GetString("btnStop.ToolTip"));
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExplorer
            // 
            resources.ApplyResources(this.btnExplorer, "btnExplorer");
            this.btnExplorer.Name = "btnExplorer";
            this.mainToolTip.SetToolTip(this.btnExplorer, resources.GetString("btnExplorer.ToolTip"));
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.clearList.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.ContextMenuStrip clearList;
        private System.Windows.Forms.ToolStripMenuItem clearListItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExplorer;
    }
}

