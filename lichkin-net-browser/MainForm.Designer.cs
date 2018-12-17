namespace lichkin_net_browser
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuStripRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripRightItemMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRightItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.ContextMenuStrip = this.contextMenuStripRight;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1000, 600);
            this.webBrowser.TabIndex = 0;
            // 
            // contextMenuStripRight
            // 
            this.contextMenuStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStripRightItemMinimize,
            this.contextMenuStripRightItemClose});
            this.contextMenuStripRight.Name = "contextMenuStripRight";
            this.contextMenuStripRight.Size = new System.Drawing.Size(113, 48);
            // 
            // contextMenuStripRightItemMinimize
            // 
            this.contextMenuStripRightItemMinimize.Name = "contextMenuStripRightItemMinimize";
            this.contextMenuStripRightItemMinimize.Size = new System.Drawing.Size(112, 22);
            this.contextMenuStripRightItemMinimize.Text = "最小化";
            this.contextMenuStripRightItemMinimize.Click += new System.EventHandler(this.contextMenuStripRightItemMinimize_Click);
            // 
            // contextMenuStripRightItemClose
            // 
            this.contextMenuStripRightItemClose.Name = "contextMenuStripRightItemClose";
            this.contextMenuStripRightItemClose.Size = new System.Drawing.Size(112, 22);
            this.contextMenuStripRightItemClose.Text = "关闭";
            this.contextMenuStripRightItemClose.Click += new System.EventHandler(this.contextMenuStripRightItemClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LichKin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRight;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripRightItemMinimize;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStripRightItemClose;
    }
}

