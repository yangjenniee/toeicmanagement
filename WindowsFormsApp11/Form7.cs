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
    public partial class Form7 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adt;
        DataSet ds;
        string sql;
        public Form7()
        {
            InitializeComponent();
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\exCS\\WindowsFormsApp11\\StudentDB.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //날짜하나만 선택할거라서 SelectionStart ,yyyyMMdd 형태로 포맷  
            textBox1.Text = monthCalendar1.SelectionStart.ToString("yyyyMMdd");
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            //날짜하나만 선택할거라서 SelectionStart ,yyyyMMdd 형태로 포맷  
            textBox2.Text = monthCalendar2.SelectionStart.ToString("yyyyMMdd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //날짜입력(추가)
            if (textBox1.Text == "")
            {
                MessageBox.Show("수험날짜를 선택하세요", "수험날짜미클릭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id1,id2;
                int id,date,dday;

                id1 = textBox1.Text; 
                id2= id1.Substring(5,3); //기본키는 월,일 
                id = Convert.ToInt32(id2);
                date = Convert.ToInt32(textBox1.Text);
                dday = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text); 

                con.Open();
                 //추가 = insert into 테이블 values 넣을 값 
                sql = "Insert into TBdate " +
                    " values ( '" + id + "' , '" + date + "','" + dday + "' )";
                cmd = new SqlCommand(sql, con);//sql문 실행
                cmd.ExecuteNonQuery();//db의 입력,수정,삭제의 sql 문 실행 
                //메세지박스출력
                MessageBox.Show("저장되었습니다.", "날짜등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'studentDBDataSet8.TBdate' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBdateTableAdapter4.Fill(this.studentDBDataSet8.TBdate);
            // TODO: 이 코드는 데이터를 'studentDBDataSet7.TBdate' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tBdateTableAdapter3.Fill(this.studentDBDataSet7.TBdate);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //새로고침 버튼 
            SqlDataAdapter adt;
            DataSet ds;
            sql = "select id,date,dday from TBdate";
            adt = new SqlDataAdapter(sql, con);  //sql문을 실행할 객체
            ds = new DataSet();   //결과가 들어갈 집합체
            adt.Fill(ds);         //Sql에 대한 결과를 집합체에 연결
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //d-day 변경 (그리드뷰에서 시험날짜를 조회 후 오늘 날짜로 새로 입력하면
            //d day를 새로 계산해줌) 
            
            int date, dday;

            date = Int32.Parse(textBox1.Text);
            dday = Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text);
            con.Open();
            //수정 - > update 테이블이름 set 바꿀 내용 where 조건 
            //그리드뷰에서 시험날짜 확인후 시험날짜를 선택 후 
            //dday를 오늘 날짜로 선택하면 다시 d-day를 계산해줌  
            sql = "update TBdate " +
                " set dday = '" + dday + "'" +
                " where date = '" + date + "'";
            cmd = new SqlCommand(sql, con); //sql문 실행을 위한 문
            cmd.ExecuteNonQuery();//입력,수정,삭제는 Excutenonquery
            //메세지박스출력
            MessageBox.Show("D-Day가 수정되었습니다.", "수정완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //날짜삭제 
            //조회화면을 보고 날짜를 확인 뒤 삭제할 수 있게끔 만들어놈.
            int date = Convert.ToInt32(textBox1.Text);
            con.Open();
            //삭제구문
            //delete from 테이블이름 where 조건  (date<시험날짜>와 같으면 삭제)
            sql = "delete from TBdate " +
                " where date = '" + date + "'";
            cmd = new SqlCommand(sql, con); //delete 구문과 con을 보내줌
            cmd.ExecuteNonQuery();//입력,수정,삭제 구문은 excutenonquery 
            //메세지박스출력 
            textBox1.Text = "";textBox2.Text = "";
            MessageBox.Show("삭제되었습니다", "날짜삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


