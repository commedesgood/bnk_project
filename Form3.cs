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

namespace FinalHomework
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        string sql;

        public Form3(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'reservationDataSet4.tbShedual' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tbShedualTableAdapter.Fill(this.reservationDataSet4.tbShedual);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = maskedTextBox1.Text; string value2 = maskedTextBox2.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            if ((value1 == "    -  -") | (value2 == "    -  -"))
                sql = " select * from tbShedual ";
            else
            {
                sql = " select * from tbShedual " + " where sdate >= '" + value1 + "' and " +
                    "sdate <= '" + value2 + "' ";
            }

            GridRetrival(sql);
        }

        private void GridRetrival(string sql)
        {
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table.DefaultView;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            maskedTextBox1.Text = e.Start.Date.ToShortDateString();
            maskedTextBox2.Text = e.End.Date.ToShortDateString();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("달력을 통해 날짜를 입력해주세요!(Drag시 날짜설정가능)");
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("달력을 통해 날짜를 입력해주세요!(Drag시 날짜설정가능)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value1 = maskedTextBox1.Text; string value2 = maskedTextBox2.Text;

            sql = " select count(sid), sum(samount), avg(samount) from tbShedual " + 
                " where sdate >= '" + value1 + "' and " + "sdate <= '" + value2 + "' ";

            cmd = new SqlCommand(sql, con);

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader[0].ToString();   //count
                textBox2.Text = reader[1].ToString();   //sum
                textBox3.Text = reader[2].ToString();   //avg
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //groupBox2.Show();
            label4.Text = System.DateTime.Now.ToString("yyyy-MM-dd  hh:mm:ss");
        }
    }
}
