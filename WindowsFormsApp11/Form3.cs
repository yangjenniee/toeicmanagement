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
   

    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adt;
        DataSet ds;
        string sql;
        public Form3(SqlConnection con) //con 객체를 받아오기 
        {
            InitializeComponent();
            this.con = con; //연결을 받아서 처리 
            if (con.State != ConnectionState.Open) ///오픈이 안됐다면
                con.Open(); //오픈해주기 
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'studentDBDataSet2.TBstudent' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBstudentTableAdapter2.Fill(this.studentDBDataSet2.TBstudent);

            // TODO: 이 코드는 데이터를 'studentDBDataSet1.TBstudent' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBstudentTableAdapter.Fill(this.studentDBDataSet1.TBstudent);
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select id,name,goal,test,class from TBstudent";

            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       public void displayGrid(string sql) //사용자정의함수 
        {
            adt = new SqlDataAdapter(sql, con); //데이터를 사용할 수 있게 하는 클래스 
            ds = new DataSet(); //SqlDataAdapter에서 가져온 데이터를 메모리상의 데이터 객체인 dataset에 할당
            adt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0]; //그리드뷰 채우기 
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //성적부실 학생조회
            //600점 이하의 학생=성적부실 
            int lowscore = 600;
            

            sql = "select id,name,goal,test,class from TBstudent " +
                " where test <='" + lowscore + "' ";

            displayGrid(sql); //그리드뷰 채우기 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            //성적우수 학생조회
            //800점 이상의 학생 = 성적우수 
            int highscore = 800;


            sql = "select id,name,goal,test,class from TBstudent " +
                " where test >='" + highscore + "' ";

            displayGrid(sql); //그리드뷰 채우기 
        }

        private void button4_Click(object sender, EventArgs e)
        { //종료버튼
            //con이 닫혀있지않으면 닫음
            if (con.State != ConnectionState.Closed)
                con.Close();
            this.Close();//현재화면 닫기 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //전체 학생조회
            //id,name,goal,test,class만 출력 
            sql = "select id,name,goal,test,class from TBstudent ";
            displayGrid(sql); //그리드뷰 채우기
                
        }
    }
}
