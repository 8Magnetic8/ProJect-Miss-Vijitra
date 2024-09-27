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
    public partial class TreatmentMethod : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public TreatmentMethod()
        {
            InitializeComponent();
            connectDB();
            getTreatmentMethod();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=Agent;Initial Catalog=CScompany;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
            getTreatmentMethod();
        }

        public void getTreatmentMethod()
        {
            cmd.CommandText = "select * from TreatmentMethod";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns[0].HeaderText = "รหัสวิธีรักษา";
            dataGridView1.Columns[1].HeaderText = "คำอธิบาย";
            dataGridView1.Columns[2].HeaderText = "ราคา";
            dataGridView1.Columns[3].HeaderText = "รหัสพนักงาน";
        }

        private void TreatmentMethodsID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from TreatmentMethods where TreatmentMethodsID = '" + TreatmentMethodsID.Text + "' ";
                
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    Description.Text = rs.GetString(1);
                    TreatmentMethodsPrice.Text = rs.GetString(2);
                    EmployeeID.Text = rs.GetString(3);
                }
                else
                {
                    Description.Clear();
                    TreatmentMethodsPrice.Clear();
                    EmployeeID.Clear();
                }
                rs.Close();
            }
            Description.Focus();
        }

        private void TreatmentMethodsPrice_KeyDown(object sender, KeyEventArgs e)
        {
            EmployeeID.Focus();
        }

        private void Description_KeyDown(object sender, KeyEventArgs e)
        {
            TreatmentMethodsPrice.Focus();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            TreatmentMethodsID.Clear();
            Description.Clear();
            TreatmentMethodsPrice.Clear();
            EmployeeID.Clear();
            TreatmentMethodsID.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into TreatmentMethods values('" + TreatmentMethodsID.Text + "','" + Description.Text + "','" + TreatmentMethodsPrice.Text + "','" + EmployeeID.Text + "')";
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
                cmd.CommandText = "update TreatmentMethods set Description='" + Description.Text + "',TreatmentMethodsPrice='" + TreatmentMethodsPrice.Text + "',EmployeeID='" + EmployeeID.Text + "' where TreatmentMethodsID='" + TreatmentMethodsID.Text + "'";
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
                cmd.CommandText = "delete from TreatmentMethods where TreatmentMethodsID='" + TreatmentMethodsID.Text + "' and Description='" + Description.Text + "' and TreatmentMethodsPrice='" + TreatmentMethodsPrice.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณต้องการที่จะลบหรือไม่", "OK", MessageBoxButtons.OKCancel);
                TreatmentMethodsID.Clear();
                Description.Clear();
                TreatmentMethodsPrice.Clear();
                EmployeeID.Clear();
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
