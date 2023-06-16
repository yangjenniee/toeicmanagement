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
    public partial class Form1 : Form
    {
        //다른 event에서도 쓰기 위해 전역위치에 배치
        SqlConnection con; //db연결하는 객체는 con
        SqlCommand cmd; //sql 문을 처리하는 cmd 객체 
        SqlDataReader reader;// 데이터조회 할때 쓰는 reader 객체 
        SqlDataAdapter adt; //그리드뷰를 위해 어댑터 추가 
        DataSet ds;

        string sql;
        public Form1()
        {
            InitializeComponent();
            //db연결경로 
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\exCS\\WindowsFormsApp11\\StudentDB.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr); //constr 정보를 이용해서 con 객체에 정보를 연결
            this.con = con;
            if (con.State != ConnectionState.Open) //오픈이 안됐다면 
                con.Open();//오픈해주기

        }

        private void 수강생등ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form2= 입학원서 화면
            Form2 frm2 = new Form2(); //form 을 하나의 객체로 취급
            frm2.Show();//새로운 화면을 보여줌
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//종료버튼
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'studentDBDataSet1.TBstudent' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBstudentTableAdapter1.Fill(this.studentDBDataSet1.TBstudent);

        }

        private void 성적관리ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //form3=성적관리화면
            Form frm3 = new Form3(con);//con 객체 값을 보내줌 (데이터베이스 연결정보를 가진 con)
            frm3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select id,name,goal,test,class from TBstudent";

            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void 시간표ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form4=모의고사 점수통계화면
            Form frm4 = new Form4(con);//con 객체 값을 보내줌 (데이터베이스 연결정보를 가진 con)
            frm4.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {  
            //새로고침버튼
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select id,name,goal,test,class from TBstudent";

            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            //form5= LC 예상문제 화면 
            Form frm5 = new Form5();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //form6=RC 예상문제 화면 
            Form frm6 = new Form6();
            frm6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form7 토익일정관리데이터베이스 관련 화면 
            Form frm7 = new Form7();
            frm7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        { 
            //화면종료 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //토익관련 사이트 이동
            Form frm8 = new Form8();
            frm8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //form 11 = 조회업무 창
            Form frm11 = new Form11(con);//con 객체 값을 보내줌 (데이터베이스 연결정보를 가진 con)
            frm11.Show();
        }
    }
}
   

