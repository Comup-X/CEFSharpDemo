using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEFSharpDemo
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser;

        private TextBox address;

        public Form1()
        {
            InitializeComponent();
            var setting = new CefSettings();
            setting.Locale = "zh-CN";
            Cef.Initialize(setting, true, false);
            browser = new ChromiumWebBrowser("https://www.baidu.com");
            address = new TextBox();
            address.KeyPress += Address_KeyPress;
            Controls.Add(address);
            Controls.Add(browser);
        }

        private void Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                browser.Load(address.Text);
            }
        }
    }
}
