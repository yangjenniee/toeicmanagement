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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        string sql;
        public Form2()
        {
           
            InitializeComponent();
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\exCS\\WindowsFormsApp11\\StudentDB.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr);
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            //종료버튼
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //목표점수에 따라 수강반과,수강비가 자동선택되도록 설정함.
            string score = comboBox1.SelectedItem.ToString();
            if (score == "600+")
            {
                textBox7.Text = "왕초보반";
                textBox10.Text = "129000";
            }
            else if (score == "700+")
            {
                textBox7.Text = "끝토익700반";
                textBox10.Text = "219000";
            }
            else if (score == "800+")
            {
                textBox7.Text = "끝토익800반";
                textBox10.Text = "229000";
            }
            else
            {
                textBox7.Text = "실전반";
                textBox10.Text = "300000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //등록버튼 
            if (textBox8.Text == "")
            {
                MessageBox.Show("입학번호 생성 버튼을 눌러주세요.", "입학버튼미클릭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id, name, age, phone, school, address, goal, test, cla, date, cost;
                id = textBox8.Text;
                name = textBox1.Text;
                age = textBox2.Text;
                phone = textBox3.Text;
                school = textBox4.Text;
                address = textBox5.Text;
                goal = comboBox1.SelectedItem.ToString();
                test = textBox6.Text;
                cla = textBox7.Text;
                date = textBox9.Text;
                cost = textBox10.Text;

                con.Open();
                //등록 -> insert into 테이블명 values ( 항목 ) 
                sql = "Insert into TBstudent " +
                    " values ( '" + id + "', N'" + name + "','" + age + "', '" + phone + "', N'" + school + "',  N'" + address + "','" + goal + "','" + test + "', N'" + cla + "','" + date + "', '" + cost + "')";

                cmd = new SqlCommand(sql, con); //sql명령을 실행하는 명령 (sql문과 db연결 정보를 옵션으로)
                cmd.ExecuteNonQuery(); //입력,수정,삭제문은 excuteNonQuery사용 
                //저장완료 메세지박스 출력 
                MessageBox.Show("저장되었습니다.", "학생등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {  //경성대학생 체크 시 할인 
            if (checkBox1.Checked)
            {
                double price = float.Parse(textBox10.Text);
                textBox10.Text = (price - (price * 0.05)).ToString();
            }
        }

        private void monthCalendar1_DataSelected(object sender, DateRangeEventArgs e)
        {
            //날짜하나만 선택할거라서 SelectionStart ,yyyyMMdd 형태로 포맷  
            textBox9.Text = monthCalendar1.SelectionStart.ToString("yyyyMMdd");
        }

        

        private void button5_Click(object sender, EventArgs e)
        {   //입학번호 생성버튼
            //기본키가 되는 입학번호를 생성해준다
            //번호 뒷자리 4개가 기본키 
            string phone = textBox3.Text;
            string num = phone.Substring(7, 4);
            textBox8.Text = num;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //이름을 누르면 모든값이 없어지도록
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedItem = "";
            textBox9.Text = "";
            textBox10.Text = ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //수정버튼 
            string id, name, age, phone, school, address, goal, test, cla, cost,date;
            id = textBox8.Text;
            name = textBox1.Text;
            age = textBox2.Text;
            phone = textBox3.Text;
            school = textBox4.Text;
            address = textBox5.Text;
            goal = comboBox1.SelectedItem.ToString();
            test = textBox6.Text;
            cla = textBox7.Text;
            cost = textBox10.Text;
            date = textBox9.Text;
            con.Open();
            //수정 = update 테이블이름 set 수정할 항목 where 수정조건 
            sql = "update TBstudent" +
                " set name = N'" + name + "'," +
                " age = '" + age + "'," +
                " phone = '" + phone + "'," +
                " school = N'" + school + "'," +
                " address = N'" + address + "'," +
                " goal = '" + goal + "'," +
                " test = '" + test + "'," +
                " class =  N'" + cla + "'," +
                " cost = '" + cost + "' ," +
                " date = '" + date + "' " +
                " where id = '" + id + "' ";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();//insert,delete,update는 excutenonquery 메서드
            //수정완료 메세지박스 출력
            MessageBox.Show("수정되었습니다.","수정완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Clear 
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = 0;
            textBox9.Text = "";
            textBox10.Text = "";
            checkBox1.Checked = false;
            con.Close();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            //조회버튼 (입력된 등록번호와 일치하는 데이터 검색)
            string value1 = textBox8.Text;
            con.Open();
            //select 선택할 항목 from 테이블 where 조건 
            sql = "select * from TBstudent" +
                " where id = '" + value1 + "' ";
            cmd = new SqlCommand(sql, con); //sql 문을 실행하는 객체는 cmd 
            reader = cmd.ExecuteReader(); //데이터를 읽을 때 쓰는 메서드는 ExcuteReader()
                                          //reader 객체에 연결 
          
                while (reader.Read()) //reader객체에서 read(읽는 명령) 
                {
                    textBox8.Text = reader["id"].ToString();
                    textBox1.Text = reader["name"].ToString();
                    textBox2.Text = reader["age"].ToString();
                    textBox3.Text = reader["phone"].ToString();
                    textBox4.Text = reader["school"].ToString();
                    textBox5.Text = reader["address"].ToString();
                    comboBox1.SelectedItem = reader["goal"].ToString();
                    textBox6.Text = reader["test"].ToString();
                    textBox7.Text = reader["class"].ToString();
                    textBox9.Text = reader["date"].ToString();
                    textBox10.Text = reader["cost"].ToString();
                
                   }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //삭제버튼 
            string id = textBox8.Text;
            con.Open();
            //delete from 테이블 where 조건 
            cmd.CommandText = "delete from TBstudent " +
                " where id = '" + id + "'";
            cmd.ExecuteNonQuery(); //delete는 ExcuteNonQuery
            con.Close();//db사용 끝났으니 닫아줌 
            //초기화
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = 0;
            textBox9.Text = "";
            textBox10.Text = "";
            checkBox1.Checked = false;
            //메세지박스 출력 
            MessageBox.Show("삭제되었습니다", "회원삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
