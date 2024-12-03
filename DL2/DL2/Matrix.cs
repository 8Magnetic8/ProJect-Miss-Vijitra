using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DL2
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
            int[,] A = { {3,6,1,2},
                         {1,5,6,7},
                         {9,2,4,1}
                        };
            int[,] B = { {5,4,8,9},
                         {6,3,5,9},
                         {8,3,2,7}
                        };
            int[,] D = { {5,8},
                         {6,4},
                         {3,5},
                         {5,9}};
            //int[,] C = new int[A.GetLength(0), A.GetLength(1)];
            //Console.WriteLine(A[0, 0]);
            //Console.WriteLine(A[0, 1]);
            //int age = 15;
            //if(age >= 18)
            //{
            //    System.Diagnostics.Debug.WriteLine("OK");
            //}
            //System.Diagnostics.Debug.WriteLineIf(age <= 18, "OK");
            //string result = age <= 18 ? "Y" : "X";
            //Console.WriteLine(result);
            ShowMartrix(A);
            ShowMartrix(B);
            ShowMartrix(D);
            //PlusMartrix(A, B);

            int[,] C = PlusMartrix(A,B);
            ShowMartrix(C);

            C = MinusMartrix(A, B);
            ShowMartrix(C);

            int[,] O = multiplyMartix(A,D);
            ShowMartrix(O);

        }
        private void ShowMartrix(int[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++) // วนรอบแถว
            {
                for (int j = 0; j < data.GetLength(1); j++) // วนรอบคอลัมน์
                {
                    Console.Write(data[i, j] + " "); // แสดงค่าของ data ในตำแหน่ง (i, j)
                    
                }
                Console.WriteLine(""); // ขึ้นบรรทัดใหม่หลังจากแสดงแต่ละแถว              
            }
            Console.WriteLine("----------");
        }
        private int[,] PlusMartrix(int[,]A,int[,]B)
        {
            int[,] C = new int[A.GetLength(0),A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++) // วนรอบคอลัมน์
                {
                    C[i, j] = A[i, j] + B[i, j];
                }  
            } 
            return C;
        }
        private int[,] MinusMartrix(int[,] A, int[,] B)
        {
            int[,] C = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++) // วนรอบคอลัมน์
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
            return C;
        }
        private int[,] multiplyMartix(int[,] A, int[,]D)
        {
            int[,] O = new int[A.GetLength(0), D.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++) // วนรอบคอลัมน์
                {
                    for (int k = 0; k < D.GetLength(1); k++) // วนรอบคอลัมน์
                    {
                        O[i,k] += A[i, j] * D[j, k];
                    }
                }
            }
            return O;
        }       
    }
}
