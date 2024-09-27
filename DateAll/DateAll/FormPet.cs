using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet
{
    public partial class FormPet : Form
    {
        public FormPet()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            PetCode.Text = "";
            Owner.Clear();
            PetName.Clear();
            PetType.Clear();
            old.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void bShow_Click(object sender, EventArgs e)
        {
            string gender = radioButton1.Checked ? "เพศผู้" : (radioButton2.Checked ? "เพศเมีย" : "ไม่ระบุเพศ");

            MessageBox.Show("Pet Code: " + PetCode.Text + "\n" +
                "Owner: " + Owner.Text + "\n" +
                "Pet Name: " + PetName.Text + "\n" +
                "Pet Type: " + PetType.Text + "\n" +
                "Old: " + old.Text + "\n" +
                "Gender: " + gender,
                "ข้อมูลสัตว์เลี้ยง");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;

            dataGridView1.Rows[r].Cells[0].Value = PetCode.Text;
            dataGridView1.Rows[r].Cells[1].Value = Owner.Text;
            dataGridView1.Rows[r].Cells[2].Value = PetName.Text;
            dataGridView1.Rows[r].Cells[3].Value = PetType.Text;
            dataGridView1.Rows[r].Cells[4].Value = old.Text;

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

        private void bBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            openFileDialog.Title = "เลือกภาพ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    pictureBox1.Image = System.Drawing.Image.FromFile(fileInfo.FullName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("ไม่ได้เลือกรูปภาพ");
                }
            }
         }
    }
}
