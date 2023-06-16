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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.hackers.co.kr/"); //해커스 토익 사이트로 이동
            this.WindowState = FormWindowState.Maximized;//화면에 꽉차도록 
        }
    }
}
