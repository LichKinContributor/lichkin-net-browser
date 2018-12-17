using LichKin.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lichkin_net_browser
{
    /// <summary>
    ///     主窗体
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        ///     构造方法
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     主窗体加载后事件
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 使用配置文件初始化
            initByConfigs();
        }

        // 配置文件
        private static String CONFIG_FILE_NAME = "/opt/security/browser.json";
        // 配置图标
        private static String ICON_FILE_NAME = "/opt/security/browser.ico";
        /// <summary>
        ///     使用配置文件初始化
        /// </summary>
        private void initByConfigs()
        {
            Dictionary<String, String> config = JSONFileReader.Read(CONFIG_FILE_NAME);
            this.Text = DictionaryUtils.GetString(config, "Title", "LichKin");
            webBrowser.Url = new Uri(DictionaryUtils.GetString(config, "Url", "http://www.lichkin.com/"));
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(ICON_FILE_NAME);
        }

        /// <summary>
        ///     最小化
        /// </summary>
        private void contextMenuStripRightItemMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        /// <summary>
        ///     关闭
        /// </summary>
        private void contextMenuStripRightItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
