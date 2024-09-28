using Pet;
using Project1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateAll
{
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
        }

        private void formPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormPet form = new FormPet();
            //form.Show();
        }

        private void dataAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataAll form = new DataAll();
            form.Show();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine form = new Medicine();
            form.Show();
        }

        private void medicineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineType form = new MedicineType();
            form.Show();
        }

        private void typePetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypePet form = new TypePet();
            form.Show();
        }

        private void รหสวธการรกษาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treatment form = new Treatment();
            form.Show();
        }

        private void การรกษาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentMethod form = new TreatmentMethod();
            form.Show();
        }
    }
}
