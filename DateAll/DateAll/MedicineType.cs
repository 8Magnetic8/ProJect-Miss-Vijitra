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
    public partial class MedicineType : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public MedicineType()
        {
            
            InitializeComponent();
            connectDB();
            getMedicineType();
        }
        public void connectDB()
        {
            conn.ConnectionString = "Data Source=LAPTOP-CPNT5JOF;Initial Catalog=petClinic;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
            getMedicineType();
        }

        public void getMedicineType()
        {
            cmd.CommandText = "select * from MedicineType";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "รหัสประเภทยา";
            dataGridView1.Columns[1].HeaderText = "ชื่อประเภทยา";

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            MedicineTypeID.Clear();
            MedicineTypeName.Clear();
            MedicineTypeID.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into MedicineType values('" + MedicineTypeID.Text + "','" + MedicineTypeName.Text + "')";
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
                cmd.CommandText = "update MedicineType set MedicineTypeName='" + MedicineTypeName.Text + "' where MedicineTypeID='" + MedicineTypeID.Text + "'";
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
                cmd.CommandText = "delete from MedicineType where MedicineTypeID='" + MedicineTypeID.Text + "' and MedicineTypeName='" + MedicineTypeName.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณต้องการที่จะลบหรือไม่", "OK", MessageBoxButtons.OKCancel);
                MedicineTypeID.Clear();
                MedicineTypeName.Clear();
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

        private void MedicineTypeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from MedicineType where MedicineTypeID='" + MedicineTypeID.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    MedicineTypeName.Text = rs.GetString(1);
                }
                rs.Close();
            }
        }

        private void MedicineTypeName_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
