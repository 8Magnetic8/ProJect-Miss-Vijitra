﻿using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            int gridSize = 3; // ขนาดของตาราง
            List<(string path, int steps)> allPaths = FindPathsUsingStack(gridSize); // แก้ไขให้เก็บทั้งเส้นทางและจำนวนก้าว
            string result = $"จำนวนเส้นทางทั้งหมด: {allPaths.Count}\n\nเส้นทางทั้งหมด:\n";

            // เพิ่มการแสดงจำนวนการเคลื่อนที่ของแต่ละเส้นทาง
            foreach (var pathInfo in allPaths)
            {
                result += $"{pathInfo.path} (จำนวนก้าว: {pathInfo.steps})\n";
            }

            MessageBox.Show(result, "Paths");
        }

        private static List<(string path, int steps)> FindPathsUsingStack(int gridSize)
        {
            // สร้าง Stack สำหรับเก็บข้อมูลเส้นทาง
            Stack<(int x, int y, string path, int steps)> stack = new Stack<(int, int, string, int)>();
            List<(string path, int steps)> allPaths = new List<(string, int)>();

            // เริ่มต้นจากจุด (0,0) เป็นการดก็บพิกัดเริ่มต้นและจำนวนก้าวเป็น 0
            stack.Push((0, 0, "(0,0)", 0));

            // วนลูปจนกว่า Stack จะว่าง
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int x = current.x;
                int y = current.y;
                string path = current.path;
                int steps = current.steps; // จำนวนก้าวที่เดินไปแล้ว

                // ถ้าถึงจุดหมายปลายทาง
                if (x == gridSize && y == gridSize)
                {
                    allPaths.Add((path, steps)); // เพิ่มเส้นทางและจำนวนก้าวลงในผลลัพธ์
                    continue;
                }

                // ถ้าเดินไปทางขวาได้
                if (x + 1 <= gridSize)
                    stack.Push((x + 1, y, path + $" -> ({x + 1},{y})", steps + 1));

                // ถ้าเดินลงล่างได้
                if (y + 1 <= gridSize)
                    stack.Push((x, y + 1, path + $" -> ({x},{y + 1})", steps + 1));
            }

            return allPaths;
        }
    }