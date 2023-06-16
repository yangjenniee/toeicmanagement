using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.toeic.co.kr/"); //토익사이트로 연결 
            this.WindowState = FormWindowState.Maximized;//최대사이즈로 (꽉 찬 사이즈)
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
