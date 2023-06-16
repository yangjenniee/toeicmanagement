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
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adt;
        DataSet ds;
        string sql;
        public Form4(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            if (con.State != ConnectionState.Open)
                con.Open();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'studentDBDataSet3.TBstudent' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBstudentTableAdapter1.Fill(this.studentDBDataSet3.TBstudent);
    
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select id,name,goal,test,class from TBstudent";

            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //600점이하 조회 버튼 
            int test = 600;

            //600점이하를 조회하고, 점수를 오름차순 으로 정렬 
            sql = "select id,name,goal,test,class from TBstudent " +
                " where test <='" + test + "' " +
                " order by test ";

            displayGrid(sql); //그리드뷰 채우기 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //종료버튼 
            this.Close();
        }

        public void displayGrid(string sql)
        {
            adt = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //600점대 학생 조회 
            int test = 600;
            int test2 = 700;

            //600점 이상이하고 700점미만인 학생을 오름차순으로 정렬 
            sql = "select id,name,goal,test,class from TBstudent " +
                " where test >='" + test + "' AND test< '" + test2 + "'" +
                " order by test ";

            displayGrid(sql); //그리드뷰 채우기 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //700점대 학생조회 
            int test = 700;
            int test2 = 800;

            //700점 이상이고 800점 미만인 학생을 오름차순으로 정렬 
            sql = "select id,name,goal,test,class from TBstudent " +
                " where test >='" + test + "' AND test< '" + test2 + "'" +
                " order by test ";

            displayGrid(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //800점대 학생 조회
            int test = 800;
            int test2 = 900;

            //800점 이상이고 900점 미만인 학생을 오름차순으로 정렬 
            sql = "select id,name,goal,test,class from TBstudent " +
                " where test >='" + test + "' AND test< '" + test2 + "'" +
                " order by test ";

            displayGrid(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //900점 이상이고 970미만인 학생을 오름차순으로 정렬 
            int test = 900;
            int test2 = 970;


            sql = "select id,name,goal,test,class from TBstudent " +
                " where test >='" + test + "' AND test< '" + test2 + "'" +
                " order by test ";

            displayGrid(sql);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //전체학생조회(id,name,goal,test,class만)
            sql = "select id,name,goal,test,class from TBstudent";
            displayGrid(sql);
        }
    }
}
