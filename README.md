using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalHomework
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        string sql;
        public Form1()
        {
            InitializeComponent();
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\exCS\\reservation.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(conStr);
            GridRetrival();
        }

        private void GridRetrival()
        {
            sql = " select * from tbHotel ";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void GridRetrival(string sql)
        {
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table.DefaultView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'reservationDataSet1.tbHotel' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tbHotelTableAdapter.Fill(this.reservationDataSet1.tbHotel);

        }

        private void 호텔정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void 예약하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(con);
            frm2.Show();
        }

        private void 호텔예약ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)  //등록버튼
        {
            string value1, value2, value3, value4, value5;
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            value3 = comboBox1.Text;
            value4 = textBox3.Text;
            value5 = textBox4.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.CommandText = " insert into tbHotel " +
                " values ( '" + value1 + "', N'" + value2 + "', N'" + value3 + "', N'" + value4 + "', '" + value5 + "' ) ";
            cmd.ExecuteNonQuery();   //insert, update, delete문에 사용하는 메서드

            GridRetrival();
            MessageBox.Show("등록되었습니다.");

            textBox1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)  //수정버튼
        {
            string value1, value2, value3, value4, value5;
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            value3 = comboBox1.Text;
            value4 = textBox3.Text;
            value5 = textBox4.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.CommandText = " update tbHotel  " +
                " set hid = '" + value1 + "', " +
                " hname = N'" + value2 + "' , " +
                " hclass = N'" + value3 + "' ,  " +
                " hlocation = N'" + value4 + "' , " +
                " hprice = '" + value5 + "' " +
                " where hid = '" + value1 + "'   ";
            cmd.ExecuteNonQuery();   //insert, update, delete문에 사용하는 메서드

            GridRetrival();
            MessageBox.Show("수정되었습니다.");

            textBox1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)  //삭제버튼
        {
            string value1, value2, value3, value4, value5;
            value1 = textBox1.Text;
            value2 = textBox2.Text;
            value3 = comboBox1.Text;
            value4 = textBox3.Text;
            value5 = textBox4.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.CommandText = " delete from tbHotel  " +
                " where hid = '" + value1 + "'   ";
            cmd.ExecuteNonQuery();   //insert, update, delete문에 사용하는 메서드

            GridRetrival();
            MessageBox.Show("삭제되었습니다.");

            textBox1_Click(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; comboBox1.Text = ""; textBox3.Text = ""; textBox4.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = e.ColumnIndex.ToString();

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            string hotelname = textBox2.Text.Trim();
            pictureBox1.Load(hotelname + ".jpg");
        }

        private void 프로그램종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) //최저가 호텔 확인버튼
        {
            sql = " select * from tbHotel  where hprice like ( select min(hprice) from tbHotel ) ";

            GridRetrival(sql);

            textBox1_Click(sender, e);
        }

        private void 예약관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(con);
            frm3.Show();
        }
    }
}
