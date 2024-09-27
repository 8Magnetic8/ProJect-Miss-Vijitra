using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DateAll
{
    public partial class DataAll : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public DataAll()
        {
            InitializeComponent();
            conectDB();
            getOwner();
            getEmployee();
        }
        public void conectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-Q7DI747\\SQLEXPRESS;Initial Catalog=petClinic;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
        }
        public void getOwner()
        {
            cmd.CommandText = "select * from Owner";

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
            dataGridView1.Columns[2].HeaderText = "เบอร์โทร";
            dataGridView1.Columns[3].HeaderText = "mail";
        }
        public void getEmployee()
        {
            cmd.CommandText = "select * from employee";

            //ดึงข้อมูล มาใส่ใน adapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            //สร้าง table มารับข้อมูลใน adapter
            DataTable table = new DataTable();
            adapter.Fill(table);

            bindingSource2.DataSource = table;
            dataGridView2.DataSource = bindingSource2;

            dataGridView2.Columns[0].HeaderText = "รหัส";
            dataGridView2.Columns[1].HeaderText = "ชื่อ";
            dataGridView2.Columns[2].HeaderText = "ตำแหน่ง";
            dataGridView2.Columns[3].HeaderText = "เบอร์โทร";
            dataGridView2.Columns[4].HeaderText = "mail";

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            ownerID.Clear();
            ownerName.Clear();
            phonenumber.Clear();
            mail.Clear();
            ownerID.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Owner values('" + ownerID.Text + "', '" + ownerName.Text + "','" + phonenumber.Text + "','" + mail.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                getOwner();
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
                cmd.CommandText = "Update itemType set typeCode'" + ownerID.Text + "', '" + ownerName.Text + "','" + phonenumber.Text + "','" + mail.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("delete หรือไม่", "คำเตือน", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cmd.CommandText = "delete from owner where ownerID = '" + ownerID.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("delete สำเร็จ");
                    getOwner();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete ไม่สำเร็จ");
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ownerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Owner where ownerID ='" + ownerID.Text + "'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    ownerName.Text = rs.GetString(1);
                    phonenumber.Text = rs.GetString(2);
                    mail.Text = rs.GetString(3);

                }
                rs.Close();
            }
        }

        private void cNew_Click(object sender, EventArgs e)
        {
            employeeID.Clear();
            employeeName.Clear();
            position.SelectedIndex = -1;
            mail1.Clear();
            pictureBox1.Image = null;
            employeeID.Focus();
        }

        private void cInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into employee values('" + employeeID.Text + "', '" + employeeName.Text + "','" + position.Text + "','" + phonenumber1.Text + "','" + mail1.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void cUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Update employee set employee'" + employeeID.Text + "', '" + employeeName.Text + "','" + position.Text + "','" + phonenumber1.Text + "','" + mail1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void cDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("delete หรือไม่", "คำเตือน", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cmd.CommandText = "delete from employee where employeeCode = '" + employeeID.Text + "' ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("delete สำเร็จ");
                    getEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete ไม่สำเร็จ");
            }
        }

        private void cClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog สำหรับให้ผู้ใช้เลือกไฟล์
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // กำหนดฟิลเตอร์ให้แสดงเฉพาะไฟล์รูปภาพ
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // ตรวจสอบว่าผู้ใช้กด OK หลังจากเลือกไฟล์แล้วหรือไม่
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // โหลดรูปภาพจากไฟล์ที่เลือกลง PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                // ปรับขนาดของ PictureBox ให้พอดีกับรูปภาพ (Optional)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void employeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from employee where employeeID = '" + employeeID.Text + "' ";
                //อ่านข้อมูล
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    employeeName.Text = rs.GetString(1);
                    position.Text = rs.GetString(2);
                    phonenumber1.Text = rs.GetString(3);
                    mail1.Text = rs.GetString(4);
                }
                else
                {
                    employeeName.Clear();
                }
                rs.Close();
            }
        }
    }
}
