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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //ybm사이트 이동 폼으로 연결 
            Form frm9 = new Form9();
            frm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //해커스 토익 사이트 이동 폼으로 연결 
            Form frm10 = new Form10();
            frm10.Show();
        }
    }
}
