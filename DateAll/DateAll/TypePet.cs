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
    public partial class TypePet : Form
    {
        public TypePet()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            PetType.Clear();
            PetType.Clear();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("รหัส: " + comboBox1.Text + "\n" +
            "ประเภทสัตว์เลี้ยง: " + PetType.Text + "\n" +
            "พันธุ์สัตว์เลี้ยง: " + Petbreeds.Text + "\n" +
            "ข้อมูลสัตว์เลี้ยง");
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            int r = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[r].Cells[0].Value = comboBox1.Text; 
            dataGridView1.Rows[r].Cells[1].Value = PetType.Text;
            dataGridView1.Rows[r].Cells[2].Value = Petbreeds.Text;

        }
    }
}
