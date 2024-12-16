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

namespace Mid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showEvenNumber();
            tableMultiplication();
            searchData();
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
            //for (int i = 2; i <= 10; i++) 
            //{
            //    Debug.WriteLine(i);
            //}
            //int n = 20;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Debug.WriteLine(i);
            //    }
            //}
        }
        public void tableMultiplication()
        {
            int anwser ;
            for (int i = 0; i <= 12; i++)
            {
               anwser = i * 2;
               Debug.WriteLine($"2 x {i} = {anwser}");

            }
        }
        public void searchData()
        {
            int[] numbers = { 10, 20, 30, 20, 50 }; // ตัวอย่าง Array
            int target = 20; // ค่าที่ต้องการค้นหา
            List<int> indices = new List<int>(); // เก็บตำแหน่งที่เจอ

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    indices.Add(i); // เพิ่มตำแหน่งที่เจอใน List
                }
            }

            if (indices.Count > 0)
            {
                Debug.WriteLine($"{target} found at indices: {string.Join(", ", indices)}");
            }
            else
            {
                Debug.WriteLine($"{target} not found in the array.");
            }
        }

    }
}
