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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //정답확인 버튼을 누르면 정답 유무를 가르쳐줌 
            if (checkBox1.Checked)
            {
                MessageBox.Show("정답입니다");
            }
            else
            {
                MessageBox.Show("오답입니다");
            }
            checkBox1.CheckState = 0;
            checkBox2.CheckState = 0;
            checkBox3.CheckState = 0;
            checkBox4.CheckState = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //정답확인 버튼을 누르면 정답 유무를 가르쳐줌 
            if (checkBox7.Checked)
            {
                MessageBox.Show("정답입니다");
            }
            else
            {
                MessageBox.Show("오답입니다");
            }
            checkBox5.CheckState = 0;
            checkBox6.CheckState = 0;
            checkBox7.CheckState = 0;
            checkBox8.CheckState = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
