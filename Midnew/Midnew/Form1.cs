using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showEvenNumber();
            tableMultiplication();
            //searchData();
            //showEvenNumber1(1, 10);
            searchData(10);
        }
        public void showEvenNumber()
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Debug.WriteLine(i);
            //    }
            //}
            //for (int i = 2; i <= 10; i=i+2)
            //{
            //    Debug.WriteLine(i);
            //}
            //for (int i = 1; i <= n; i=i+2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Debug.WriteLine(i);
            //    }
            //}
        }
        //public void showEvenNumber1(int A, int N) 
        //{
        //    if (A % 2 == 1)  {
        //        A++;
        //    for (int i = A; i <= N; i = i + 2)
        //    {   
        //            Debug.WriteLine(i);
        //    } 
        //    }
        //}
        public void tableMultiplication()
        {
            for (int i = 0; i <= 12; i++)
            {
                Debug.WriteLine($"สูตรคูณแม่  {i} :");
                for (int j = 0; j <= 12; j++) 
                {
                   Debug.WriteLine(i + "x" + j + "=" +(i * j));
                }
            }
        }
        public String searchData(int x)
        {
            int[] data = { 20, 20, 40, 10, 80, 30,90, 60 };
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == x)
                { 
                    return "Found";
                }
            }
            return "Not Found";
        }

    }
}
