using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form11 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adt;
        DataSet ds;
        string sql;
        public Form11(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            if (con.State != ConnectionState.Open)
                con.Open();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'studentDBDataSet9.TBstudent' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBstudentTableAdapter.Fill(this.studentDBDataSet9.TBstudent);
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select * from TBstudent";

            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            sql = "select * from TBstudent " +
                " where id ='" + id + "' ";

            displayGrid(sql);
        }
        public void displayGrid(string sql)
        {
            adt = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select * from TBstudent";

            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //수정 등록 삭제 폼으로 이동
            Form2 frm2 = new Form2(); //form 을 하나의 객체로 취급
            frm2.Show();//새로운 화면을 보여줌
        }

        private void button4_Click(object sender, EventArgs e)
        { //종료버튼 
            this.Close();
        }
    }
}
