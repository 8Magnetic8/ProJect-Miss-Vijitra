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

namespace Pet
{
    public partial class TypePet : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public TypePet()
        {
            InitializeComponent();
            conectDB();
            getPetType();
        }
        public void conectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-Q7DI747\\SQLEXPRESS;Initial Catalog=petClinic;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
        }
        public void getPetType()
        {
            cmd.CommandText = "select * from PetType";

            //ดึงข้อมูล มาใส่ใน adapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            //สร้าง table มารับข้อมูลใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns[0].HeaderText = "รหัส";
            dataGridView1.Columns[1].HeaderText = "ชื่อ";
            dataGridView1.Columns[2].HeaderText = "รหัสพันธุ์";
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            
            PetTypeID.Clear();
            PetTypeName.Clear();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("รหัส: " + PetTypeID.Text + "\n" +
            "ประเภทสัตว์เลี้ยง: " + PetTypeName.Text + "\n" +
            "พันธุ์สัตว์เลี้ยง: " + PetBreedID.Text + "\n" +
            "ข้อมูลสัตว์เลี้ยง");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = PetTypeID.Text; 
            dataGridView1.Rows[r].Cells[1].Value = PetTypeName.Text;
            dataGridView1.Rows[r].Cells[2].Value = PetBreedID.Text;

        }

        private void PetTypeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from PetType where PetTypeID ='" + PetTypeID.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    PetTypeName.Text = rs.GetString(1);
                    PetBreedID.Text = rs.GetString(2);
                }
                rs.Close();
            }
        }
    }
}
