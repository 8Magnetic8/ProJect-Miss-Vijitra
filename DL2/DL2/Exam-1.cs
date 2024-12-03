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

namespace DL2
{
    public partial class Exam_1 : Form
    {
        public Exam_1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            Console.WriteLine("" + i + "" + j + "" + k + "" + l);
                            n++;
                        }
                        Console.WriteLine(n);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] data = {
        { 1, 4, 5, 6 },
        { 3, 4, 1, 3 },
        { 3, 20, 10, 6 },
        { 8, 8, 2, 3 }
    };

            int gridSizeX = data.GetLength(0) - 1; // จำนวนแถว - 1
            int gridSizeY = data.GetLength(1) - 1; // จำนวนคอลัมน์ - 1

            List<(string path, int steps)> allPaths = FindPathsUsingStack(data, gridSizeX, gridSizeY);
            string result = $"จำนวนเส้นทางทั้งหมด: {allPaths.Count}\n\nเส้นทางทั้งหมด:\n";

            // เพิ่มการแสดงจำนวนการเคลื่อนที่ของแต่ละเส้นทาง
            foreach (var pathInfo in allPaths)
            {
                result += $"{pathInfo.path} (จำนวนก้าว: {pathInfo.steps})\n";
            }

            // เพิ่มการหาค่ามากที่สุดและดัชนี
            int[] x = new int[30]; // สมมุติว่าใช้ค่าจากการคำนวณจำนวนก้าว
            for (int i = 0; i < allPaths.Count && i < x.Length; i++)
            {
                x[i] = allPaths[i].steps;  // เก็บจำนวนก้าวลงใน x
            }

           
            int max = 0;
            int maxIndex = 0; 
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                    maxIndex = i;
                }
            }

            result += $"\nค่ามากที่สุด: {max} ที่ดัชนี: {maxIndex}";

            MessageBox.Show(result, "Paths");
        }

        private static List<(string path, int steps)> FindPathsUsingStack(int[,] data, int gridSizeX, int gridSizeY)
        {
            // สร้าง Stack สำหรับเก็บข้อมูลเส้นทาง
            Stack<(int x, int y, string path, int steps)> stack = new Stack<(int, int, string, int)>();
            List<(string path, int steps)> allPaths = new List<(string, int)>();

            // เริ่มต้นจากจุด (0,0) เป็นการกำหนดพิกัดเริ่มต้นและจำนวนก้าวเป็น 0
            stack.Push((0, 0, "(0,0)", 0));

            // วนลูปจนกว่า Stack จะว่าง
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int x = current.x;
                int y = current.y;
                string path = current.path;
                int steps = current.steps;
                steps += data[x, y];
                // ถ้าถึงจุดหมายปลายทาง
                if (x == gridSizeX && y == gridSizeY)
                {
                    allPaths.Add((path, steps)); // เพิ่มเส้นทางและจำนวนก้าวลงในผลลัพธ์
                    continue;
                }

                // ถ้าเดินไปทางขวาได้
                if (x + 1 <= gridSizeX)
                    stack.Push((x + 1, y, path + $" -> ({x + 1},{y})", steps ));

                // ถ้าเดินลงล่างได้
                if (y + 1 <= gridSizeY)
                    stack.Push((x, y + 1, path + $" -> ({x},{y + 1})", steps ));
            }

            return allPaths;
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    // แสดงข้อมูลในอาเรย์ 2 มิติ
        //    int[,] data = {
        //        { 1, 4, 5, 6 },
        //        { 3, 4, 1, 2 },
        //        { 3, 20, 10, 6 },
        //        { 8, 8, 2, 3 }
        //    };

        //    string output = "ข้อมูลในอาเรย์:\n";
        //    for (int i = 0; i < data.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < data.GetLength(1); j++)
        //        {
        //            output += $"{data[i, j]} ";
        //        }
        //        output += "\n";
        //    }

        //    // แสดงผลใน MessageBox
        //    MessageBox.Show(output, "Data Array");
        //}
    }
}