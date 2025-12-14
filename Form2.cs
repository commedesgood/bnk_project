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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalHomework
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;

        string sql;

        int sum = 0;

        public Form2(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            GridRetrival();

            lblDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void GridRetrival()
        {
            sql = "select * from tbShedual";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'reservationDataSet3.tbHotel' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tbHotelTableAdapter.Fill(this.reservationDataSet3.tbHotel);
            // TODO: 이 코드는 데이터를 'reservationDataSet2.tbShedual' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.tbShedualTableAdapter.Fill(this.reservationDataSet2.tbShedual);

        }

        private void lblsamount_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(txtsamount, e.X, e.Y);
            }
        }

        private void 금액보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int hotelprice = 0;
            int hid = txtshname.SelectedIndex;

            switch (hid)
            {
                case 0: hotelprice = 120000; break;
                case 1: hotelprice = 80000; break;
                case 2: hotelprice = 77000; break;
                case 3: hotelprice = 150000; break;
                case 4: hotelprice = 99000; break;
                case 5: hotelprice = 115000; break;
            }
            sum = hotelprice * int.Parse(txtsstay.Text);

            txtsamount.Text = sum.ToString();
        }

        private void 할인금액ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int salehotelprice = 0;
            double salerate = 0;
            int bid = txtsbank.SelectedIndex;

            switch (bid)
            {
                case 0: salerate = 0.1; break;
                case 1: salerate = 0.08; break;
                case 2: salerate = 0.08; break;
                case 3: salerate = 0.06; break;
                case 4: salerate = 0.06; break;
            }

            salehotelprice = Convert.ToInt32(sum - (sum * salerate));
            txtsamount.Text = salehotelprice.ToString();

            if (salehotelprice == 0) MessageBox.Show("금액보기버튼을 먼저 눌러주세요!");
        }

        private void txtshname_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsamount.Text = "";
            MessageBox.Show("결제금액을 다시 확인해주세요!");
        }

        private void txtsbank_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsamount.Text = "";
            MessageBox.Show("결제금액을 다시 확인해주세요!");
        }

        private void txtsid_Click(object sender, EventArgs e)
        {
            txtsid.Clear(); txtsstay.Clear(); txtsamount.Clear(); txtsdate.Clear(); txtsname.Clear();
            txtshname.Text = ""; txtsbank.Text = "";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtsdate.Text = lblDate.Text;
        }

        private void button1_Click(object sender, EventArgs e)  //등록버튼
        {
            string value1, value2, value3, value4, value5, value6, value7;
            value1 = txtsid.Text;
            value2 = txtshname.Text;
            value3 = txtsbank.Text;
            value4 = txtsstay.Text;
            value5 = txtsamount.Text;
            value6 = txtsdate.Text;
            value7 = txtsname.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.CommandText = " insert into tbShedual " +
                " values ( '" + value1 + "', N'" + value2 + "', N'" + value3 + "', '" + value4 + "', '" + value5 + "', '" + value6 + "', N'" + value7 + "') ";
            cmd.ExecuteNonQuery();   //insert, update, delete문에 사용하는 메서드

            GridRetrival();
            MessageBox.Show("등록되었습니다.");
            txtsid_Click(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)  //수정버튼
        {
            string value1, value2, value3, value4, value5, value6, value7;
            value1 = txtsid.Text;
            value2 = txtshname.Text;
            value3 = txtsbank.Text;
            value4 = txtsstay.Text;
            value5 = txtsamount.Text;
            value6 = txtsdate.Text;
            value7 = txtsname.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.CommandText = " update tbShedual " +
                " set sid = '" + value1 + "', " +
                " shname = N'" + value2 + "', " +
                " sbank = N'" + value3 + "', " +
                " sstay = '" + value4 + "', " +
                " samount = '" + value5 + "', " +
                " sdate = '" + value6 + "', " +
                " sname = N'" + value7 + "' " +
                " where sid = '" + value1 + "' ";
            cmd.ExecuteNonQuery();   //insert, update, delete문에 사용하는 메서드

            GridRetrival();
            MessageBox.Show("수정되었습니다.");
            txtsid_Click(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)  //삭제버튼
        {
            string value1 = txtsid.Text;

            if (con.State == ConnectionState.Open) con.Close();
            if (con.State == ConnectionState.Closed) con.Open();

            cmd.CommandText = " delete from tbShedual " +
                " where sid = '" + value1 + "' ";
            cmd.ExecuteNonQuery();
            GridRetrival();

            MessageBox.Show("삭제되었습니다.");
            txtsid_Click(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,21);

            switch(randomNumber)
            {
                case 1: listBox1.Items.Add("해운대해수욕장"); break;
                case 2: listBox1.Items.Add("감천문화마을"); break;
                case 3: listBox1.Items.Add("광안리해수욕장"); break;
                case 4: listBox1.Items.Add("국립해양박물관"); break;
                case 5: listBox1.Items.Add("송도해상케이블카"); break;

                case 6: listBox1.Items.Add("해운대블루라인파크"); break;
                case 7: listBox1.Items.Add("씨라이프부산아쿠아리움"); break;
                case 8: listBox1.Items.Add("국립부산과학관"); break;
                case 9: listBox1.Items.Add("부산어린이대공원"); break;
                case 10: listBox1.Items.Add("롯데월드어드벤처부산"); break;

                case 11: listBox1.Items.Add("해동용궁사"); break;
                case 12: listBox1.Items.Add("태종대"); break;
                case 13: listBox1.Items.Add("스포원파크금정체육공원"); break;
                case 14: listBox1.Items.Add("부산시민공원"); break;
                case 15: listBox1.Items.Add("부산송도해수욕장"); break;

                case 16: listBox1.Items.Add("흰여울문화마을"); break;
                case 17: listBox1.Items.Add("해운대블루라인파크"); break;
                case 18: listBox1.Items.Add("오륙도스카이워크"); break;
                case 19: listBox1.Items.Add("키자니아부산"); break;
                case 20: listBox1.Items.Add("화명생태공원"); break;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = e.ColumnIndex.ToString();

            txtsid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtshname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsbank.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsstay.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsamount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsdate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsname.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            MessageBox.Show("예약날짜의 시간을 지워주세요! \n(예약수정시 필요)");

            string bankname = txtsbank.Text.Trim();
            pictureBox1.Load(bankname + ".jpg");

            switch(bankname)
            {
                case "부산은행" : lblsalerate.Text = "10% 할인"; break;
                case "국민은행" : lblsalerate.Text = "8% 할인"; break;
                case "신한은행" : lblsalerate.Text = "8% 할인"; break;
                case "하나은행" : lblsalerate.Text = "6% 할인"; break;
                case "우리은행" : lblsalerate.Text = "6% 할인"; break;
            }
        }
    }
}
