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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //password();
            //passwordNew();
            //correct();
            //correct1();
            //correct2(200000,2);
            Debug.WriteLine(Number1(90));
        }
        public void password()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    for (char k = 'A'; k <= 'Z'; k++)
                    {
                        for (char l = 'A'; l <= 'Z'; l++)
                        {
                            Debug.WriteLine(i + j + k + l);
                        }
                    }
                }
            }
        }
        public void passwordNew()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    for (char k = 'A'; k <= 'Z'; k++)
                    {
                        for (char l = 'A'; l <= 'Z'; l++)
                        {
                            Debug.WriteLine(i + j + k + l);
                        }
                    }
                }
            }
        }
        public bool correct(int amount,int type)
        {
            switch (type)
            {
                case 1: if (amount <= 100000) return true; break;
                case 2: if (amount <= 200000) return true; break;
                case 3: if (amount <= 300000) return true; break;
                case 4: if (amount <= 400000) return true; break;
            }
            return false;
        }
        public bool correct1(int amount, int type)
        {
            int[] correct = { 100000, 200000, 300000, 400000 };
            if(amount <= correct[type - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool correct2(int amount, int type)
        {
            if (amount <= (type * 100000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private String Number1(int number)
        {
            //if(number >= 1 && number <= 9) return"กลุ่มที่1";
            //if (number >= 10 && number <= 19) return "กลุ่มที่2";
            //if (number >= 20 && number <= 29) return "กลุ่มที่3";
            //if (number >= 30 && number <= 39) return "กลุ่มที่4";
            //if (number >= 40 && number <= 49) return "กลุ่มที่5";
            //if (number >= 50 && number <= 59) return "กลุ่มที่6";
            //if (number >= 60 && number <= 69) return "กลุ่มที่7";
            //if (number >= 70 && number <= 79) return "กลุ่มที่8";
            //if (number >= 80 && number <= 89) return "กลุ่มที่9";
            //if (number >= 90 && number <= 99) return "กลุ่มที่10";
            int g = number / 10 + 1;            
            return "กลุ่มที่: " + g;
        }
    }
}
