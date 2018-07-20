namespace ProcessStation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listProcess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonKill = new System.Windows.Forms.Button();
            this.buttonProtect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProcess
            // 
            this.listProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listProcess.FullRowSelect = true;
            this.listProcess.Location = new System.Drawing.Point(15, 15);
            this.listProcess.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listProcess.MultiSelect = false;
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(671, 366);
            this.listProcess.TabIndex = 2;
            this.listProcess.UseCompatibleStateImageBehavior = false;
            this.listProcess.View = System.Windows.Forms.View.Details;
            this.listProcess.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listProcess_ColumnClick);
            this.listProcess.SelectedIndexChanged += new System.EventHandler(this.listProcess_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "  进程名称";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件名";
            this.columnHeader3.Width = 300;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(49, 423);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(146, 42);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "立即更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKill
            // 
            this.buttonKill.Location = new System.Drawing.Point(495, 426);
            this.buttonKill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(132, 39);
            this.buttonKill.TabIndex = 4;
            this.buttonKill.Text = "关闭进程";
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // buttonProtect
            // 
            this.buttonProtect.Location = new System.Drawing.Point(284, 423);
            this.buttonProtect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonProtect.Name = "buttonProtect";
            this.buttonProtect.Size = new System.Drawing.Size(132, 39);
            this.buttonProtect.TabIndex = 5;
            this.buttonProtect.Text = "保护进程";
            this.buttonProtect.UseVisualStyleBackColor = true;
            this.buttonProtect.Click += new System.EventHandler(this.buttonProtect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(701, 36);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(230, 31);
            this.toolStripStatusLabel1.Text = "正在保护进程：暂无";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(230, 31);
            this.toolStripStatusLabel2.Text = "正在阻止进程：暂无";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(398, 31);
            this.toolStripStatusLabel3.Text = "系统目前正在运行的进程数为：未知";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(701, 520);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonProtect);
            this.Controls.Add(this.buttonKill);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ProcessStation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listProcess;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.Button buttonProtect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

