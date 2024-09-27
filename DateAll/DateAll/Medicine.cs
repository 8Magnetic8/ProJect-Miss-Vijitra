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
    public partial class Medicine : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Medicine()
        {
            
            InitializeComponent();
            connectDB();
            getMedicine();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=LAPTOP-CPNT5JOF;Initial Catalog=petClinic;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
            getMedicine();
        }

        public void getMedicine()
        {
            cmd.CommandText = "select MedicineID,MedicineName,qty,price,Unit,MedicineTypeID from Medicine";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns[0].HeaderText = "รหัสยา";
            dataGridView1.Columns[1].HeaderText = "ชื่อยา";
            dataGridView1.Columns[2].HeaderText = "จำนวน";
            dataGridView1.Columns[3].HeaderText = "ราคา";
            dataGridView1.Columns[4].HeaderText = "หน่วยนับ";
            dataGridView1.Columns[5].HeaderText = "รหัสประเภทยา";
            
        }

        private void MedicineID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Medicine where MedicineID = '" + MedicineID.Text + "' ";
                
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    MedicineName.Text = rs.GetString(1);
                    MedicineTypeID.Text = rs.GetString(5);
                    MedicineQuantity.Text = rs.GetInt32(2).ToString();
                    MedicinePrice.Text = rs.GetInt32(3).ToString();
                    Unit.Text = rs.GetString(4);
                }
                else
                {
                    MedicineName.Clear();
                }
                rs.Close();
            }
        }

        private void MedicineName_KeyDown(object sender, KeyEventArgs e)
        {
            MedicineTypeID.Focus();
        }

        private void MedicineTypeID_KeyDown(object sender, KeyEventArgs e)
        {
            MedicineQuantity.Focus();
        }

        private void MedicineQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            MedicinePrice.Focus();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            MedicineID.Clear();
            MedicineName.Clear();
            MedicineTypeID.Clear();
            MedicineQuantity.Clear();
            MedicinePrice.Clear();
            Unit.Items.Clear();
            MedicineID.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Medicine values('" + MedicineID.Text + "','" + MedicineName.Text + "','" + MedicineTypeID.Text + "','" + MedicineQuantity.Text + "','" + MedicinePrice.Text + "','" + Unit.Text + "')";
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
                cmd.CommandText = "update Medicine set MedicineName='" + MedicineName.Text + "',MedicineTypeID='" + MedicineTypeID.Text + "',MedicineQuantity='" + MedicineQuantity.Text + "',MedicinePrice='" + MedicinePrice.Text + "',Unit='" + Unit.Text + "' where MedicineID='" + MedicineID.Text + "'";
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
                cmd.CommandText = "delete from Medicine where MedicineID='" + MedicineID.Text + "' " +
                    "and MedicineName='" + MedicineName.Text + "' " +
                    "and MedicineQuantity='" + MedicineQuantity.Text + "' and MedicinePrice='" + MedicinePrice.Text + "' and Unit='" + Unit.Text +"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณต้องการที่จะลบหรือไม่", "OK", MessageBoxButtons.OKCancel);
                MedicineID.Clear();
                MedicineName.Clear();
                MedicineTypeID.Clear();
                MedicineQuantity.Clear();
                MedicinePrice.Clear();
                Unit.Items.Clear();
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
