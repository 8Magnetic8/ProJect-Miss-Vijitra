using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CRRU
{
    public partial class CRRU : Form
    {
        public CRRU()
        {
            InitializeComponent();
        }

        private void bclose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Close?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void bnew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void brun_Click(object sender, EventArgs e)
        {
            string command = richTextBox1.Lines[0];
            //inputBox inputBox = new inputBox();
            //inputBox.ShowDialog();
            //string input = "";
            //input = inputBox.UserInput;
            if (command.Substring(0,5).Equals("input"))
            {
                string vName = command.Substring(6);
                string input = new Input(vName).getData();
                Debug.WriteLine(input);
            }//loopเมือมีการป้อน a,b,c,d วนไป และเก็บชื่อไว้ไหนก่ได้แล้วแต่
            //System.Diagnostics.Debug.WriteLine(richTextBox1.Lines.Count());
            //string[] text = richTextBox1.Lines;
            //for (int i = 0; i < richTextBox1.Lines.Count() ; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine((richTextBox1.Lines[i]);
            //}
            // DialogResult result = inputBox.ShowDialog();
            // if (result == DialogResult.OK)
        }

    }
}
