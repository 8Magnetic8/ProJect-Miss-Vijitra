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

namespace Project1
{
    public partial class Treatment : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Treatment()
        {
            InitializeComponent();
            connectDB();
            getTreatment();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=Agent;Initial Catalog=CScompany;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
            getTreatment();
        }

        public void getTreatment()
        {
            cmd.CommandText = "select * from Treatment";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns[0].HeaderText = "รหัสวิธีรักษา";
            dataGridView1.Columns[1].HeaderText = "ชื่อการรักษา";
            dataGridView1.Columns[2].HeaderText = "คำอธิบาย";
            dataGridView1.Columns[3].HeaderText = "ราคา";
            dataGridView1.Columns[4].HeaderText = "วันและเวลา";

        }

        private void TreatmentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Treatment where TreatmentID = '" + TreatmentID.Text + "' ";

                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    TreatmentName.Text = rs.GetString(1);
                    Description.Text = rs.GetString(2);
                    TreatmentPrice.Text = rs.GetString(3);
                    dateTimePicker1.Text = rs.GetString(4);
                }
                else
                {
                    TreatmentName.Clear();
                    Description.Clear();
                    TreatmentPrice.Clear();
                    dateTimePicker1.Text = " ";
                }
                rs.Close();
            }
            
            TreatmentName.Focus();
        }

        private void TreatmentName_TextChanged(object sender, EventArgs e)
        {
            Description.Focus();
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            TreatmentPrice.Focus();
        }

        private void TreatmentPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            TreatmentID.Clear();
            TreatmentName.Clear();
            Description.Clear();
            TreatmentPrice.Clear();
            dateTimePicker1.Text = " ";
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Treatment values('" + TreatmentID.Text + "','" + Description.Text + "','" + TreatmentPrice.Text + "','" + TreatmentName.Text + "','" + dateTimePicker1.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update Treatment set Description='" + Description.Text + "',DateTime='" + dateTimePicker1.Text + "',TreatmentName='" + TreatmentName.Text + "',TreatmentPrice='" + TreatmentPrice.Text + "' where TreatmentID ='" + TreatmentID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณจะทำการแก้ไขข้อมูลหรือไม่", "OK", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูลซ้ำ");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete from Treatment where TreatmentID='" + TreatmentID.Text + "' and Description='" + Description.Text + "' and TreatmentPrice='" + TreatmentPrice.Text + "' and TreatmentName='" + TreatmentName.Text + "' and DateTime='" + dateTimePicker1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณต้องการที่จะลบหรือไม่", "OK", MessageBoxButtons.OKCancel);
                TreatmentID.Clear();
                TreatmentName.Clear();
                Description.Clear();
                TreatmentPrice.Clear();
                dateTimePicker1.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่มีค่าให้ลบ");
            }
        }



        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
