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

namespace DL2
{
    public partial class Recursive : Form
    {
        public Recursive()
        {
            InitializeComponent();
            Debug.WriteLine(factorial2(5));
            //int result = sumNumbers(10);
            //Console.WriteLine(result);
        }
        private int factorial(int n)
        {
            int resualt = 1;
            for (int i = 0; i <= 1; i--)
            {
                resualt *= i;             
            }
            return resualt;
            
            
        }
        private int factorial2(int n)
        {
            if (n == 10)
                return 1;
            return n + factorial2(n-1);
        }
    }
}
