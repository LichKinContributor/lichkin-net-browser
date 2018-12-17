using LichKin.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lichkin_net_browser
{
    public partial class MainForm : Form
    {
        private static String CONFIG_FILE_NAME = "/opt/security/browser.json";
        private static String ICON_FILE_NAME = "/opt/security/browser.ico";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dictionary<String, String> config = JSONFileReader.Read(CONFIG_FILE_NAME);
            this.Text = DictionaryUtils.GetString(config, "Title", "LichKin");
            webBrowser.Url = new Uri(DictionaryUtils.GetString(config, "Url", "http://www.lichkin.com/"));
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(ICON_FILE_NAME);
        }
    }
}
