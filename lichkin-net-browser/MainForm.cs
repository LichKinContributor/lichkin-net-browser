using LichKin.Utils;
using LichKin.Utils.Security;
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
        // 私钥
        private static String PRIMARY_KEY = "MIICdwIBADANBgkqhkiG9w0BAQEFAASCAmEwggJdAgEAAoGBAL4bX3AgUuEgTvLegWMk5gJcSn/+rtwnkfo7pluqhdBKhJctjKjV2kgn4lPbFOc3FPh/uILTLOlcabXDNdd7iHElxVoiF3b/kSZuIfUMdh2FcnoVY8SzvmDGjWmYK0HwbNJxWp3B/eCvR82OxeRGm3Q5lvhcjzwaFVw++EXzsLupAgMBAAECgYAXc98JQSOYXFkBA0wpBANQJTyXn77IsCUFHti+FEJf2OGUmOzyYzeDkVANkkh44cW3hmIn2Y9/1oPABa4dwEKrpEm8jqzEkN4iAuBKMS2Fb/T6fuG/60FmSMuerfPn3T3TU7GbO1RJZbUV/oVcJek6fwa+gFx67mbNgS4E09CpFQJBAOUou0qsCnq0obN//SJkP043B7fbmXwS6hEk2HHREnC5zp4Laf8XB9a+t3mrzxFQQG1PjeBvt1bH1Mcq/y4QrCMCQQDUX6xJFOE19x6lN/TkOJrSDc4hfXDww9PbUBN1fiEmi2LEnp3mUR5hFc8CmWGCQYg0eecT4yB89G5Lxd3waz/DAkEA5RCQFxZd60ZAFNOtTwFyHlb3yhsjE1k8zCJOkYbxreit1mGGdMyqs0g00tSgyae0nw/UvDIvy/k4glZCeeOEjQJAX1vSLUJ92VBr5z3X7T3pbpYaT3lW5BTaJOiwxBntYrRFlgmu1sLnxCoZuI4MdYNdWErAUnKynMjYWZewDwrpJwJBANwKlPZbBufTTLMgA655gLzESOyge8SVWwjwlLEJBDZzUYZfbCbrDf4hyAgYLgI1PFP1iJFr8U/aZHpGFA+GtzQ=";
        // 公钥
        private static String PUBLIC_KEY = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC+G19wIFLhIE7y3oFjJOYCXEp//q7cJ5H6O6ZbqoXQSoSXLYyo1dpIJ+JT2xTnNxT4f7iC0yzpXGm1wzXXe4hxJcVaIhd2/5EmbiH1DHYdhXJ6FWPEs75gxo1pmCtB8GzScVqdwf3gr0fNjsXkRpt0OZb4XI88GhVcPvhF87C7qQIDAQAB";
        /// <summary>
        ///     使用配置文件初始化
        /// </summary>
        private void initByConfigs()
        {
            try
            {
                Dictionary<String, String> config = JSONFileReader.Read(CONFIG_FILE_NAME);
                this.Text = RSAUtils.Decrypt(RSAUtils.PEM2XML(true, PRIMARY_KEY), DictionaryUtils.GetString(config, "Title", "LichKin"));
                webBrowser.Url = new Uri(RSAUtils.Decrypt(RSAUtils.PEM2XML(true, PRIMARY_KEY), DictionaryUtils.GetString(config, "Url", "http://www.lichkin.com/")));
                this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(ICON_FILE_NAME);
            }
            catch
            {
                MessageBox.Show("配置信息被篡改或已丢失，请联系管理员。", "程序即将退出");
                Application.Exit();
            }
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
