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

namespace DateAll
{
    public partial class Pet : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Pet()
        {
            InitializeComponent();
            conectDB();
            getPet();
        }
        public void conectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-Q7DI747\\SQLEXPRESS;Initial Catalog=petClinic;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
        }
        public void getPet()
        {
            cmd.CommandText = "select * from Pet";

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
            dataGridView1.Columns[2].HeaderText = "อายุ";
            dataGridView1.Columns[3].HeaderText = "เพศ";
            dataGridView1.Columns[4].HeaderText = "รูป";
            dataGridView1.Columns[5].HeaderText = "รหัสประเภท";
            dataGridView1.Columns[6].HeaderText = "รหัสเจ้าของ";

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            PetID.Text = "";
            ownerID.Clear();
            PetName.Clear();
            PetTypeID.Clear();
            PetAge.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;

            dataGridView1.Rows[r].Cells[0].Value = PetID.Text;
            dataGridView1.Rows[r].Cells[1].Value = Owner.Text;
            dataGridView1.Rows[r].Cells[2].Value = PetName.Text;
            dataGridView1.Rows[r].Cells[3].Value = PetTypeID.Text;
            dataGridView1.Rows[r].Cells[4].Value = PetAge.Text;

            string gender = radioButton1.Checked ? "เพศผู้" : (radioButton2.Checked ? "เพศเมีย" : "ไม่ระบุเพศ");
            dataGridView1.Rows[r].Cells[5].Value = gender;

            if (pictureBox1.Image != null)
            {
                dataGridView1.Rows[r].Cells[6].Value = pictureBox1.Image;
            }
            else
            {
                dataGridView1.Rows[r].Cells[6].Value = null;
            }
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            string gender = radioButton1.Checked ? "เพศผู้" : (radioButton2.Checked ? "เพศเมีย" : "ไม่ระบุเพศ");

            MessageBox.Show("Pet Code: " + PetID.Text + "\n" +
                "Owner: " + Owner.Text + "\n" +
                "Pet Name: " + PetName.Text + "\n" +
                "Pet Type: " + PetTypeID.Text + "\n" +
                "Old: " + PetAge.Text + "\n" +
                "Gender: " + gender,
                "ข้อมูลสัตว์เลี้ยง");
        }

        private void binsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Pet values('" + PetID.Text + "', '" + PetName.Text + "','" + PetAge.Text + "','" + Sex.Text + "','" + PetTypeID.Text + "','" + ownerID.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                getPet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TextBox GetPetAge()
        {
            return PetAge;
        }

        private void PetID_KeyDown(object sender, KeyEventArgs e, TextBox petAge)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Pet where PetID ='" + PetID.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    PetName.Text = rs.GetString(1);
                    petAge.Text = rs.GetString(2);
                    Sex.Text = rs.GetString(3);
                    Image.FromFile(rs.GetString(4));
                    PetTypeID.Text = rs.GetString(5);
                    ownerID.Text = rs.GetString(6);
                }
                rs.Close();
            }
        }
    }
}
