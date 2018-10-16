using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getURL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtURL_Enter(object sender, EventArgs e)
        {

        }

        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////rtcResult.Text = "";
            //string url = txtURL.Text;
            //url = url.Replace("http://127.0.0.1/", "http://test.e-map.ne.jp/");
            //rtcResult.AppendText(url);
            //if(url != "")
            //{
            //    Clipboard.SetText(url);
            //}
            
            //try
            //{
            //    webBrowser1.Navigate(new Uri(url));
            //}
            //catch (System.UriFormatException)
            //{
            //    return;
            //}
           
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = txtURL.Text;
                url = url.Replace("http://127.0.0.1/", "http://test.e-map.ne.jp/");
                rtcResult.AppendText(url);
                rtcResult.AppendText("\n");
                if (url != "")
                {
                    Clipboard.SetText(url);
                }

                try
                {
                    webBrowser1.ScriptErrorsSuppressed = true;
                    webBrowser1.Navigate(new Uri(url));
                }
                catch (System.UriFormatException)
                {
                    return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtcResult.Text = "";
        }
    }
}
