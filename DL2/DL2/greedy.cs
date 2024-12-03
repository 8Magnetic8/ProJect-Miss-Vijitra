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
    public partial class greedy : Form
    {
        public greedy()
        {
            InitializeComponent();
            ////getCoin();
            //setMoney();
            //showName();
            //int[] coin = { 5, 5, 5, 10, 10, 1, 2, 2, 1 };
            //showArray(coin);
            //showRun();
            showRunNew();
            //showHot();
        }
        private void getCoin()
        {
            int[] coin = { 5, 5, 5, 10, 10, 1, 2, 2, 1 };
            Array.Sort(coin);      
            Array.Reverse(coin);
            //int sum = coin[0] + coin[1] + coin[2];
            //Console.WriteLine(coin[0]);
            //Console.WriteLine(coin[1]);
            //Console.WriteLine(coin[2]);
            //Console.WriteLine(sum);
            
            //foreach(int x in coin)
            //{
            //    Console.WriteLine(x);
            //}
            int sum = 0;
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(coin[i]);
                sum += coin[i];
            }
            Console.WriteLine(sum);
        }
        private void setMoney() 
        {

            int[] coin = { 100, 25, 10, 5, 1 };
            int amount = 289;
            int sum = 0;

            foreach (int c in coin)
            {
                int count = amount / c; // คำนวณจำนวนเหรียญ/ธนบัตรที่ต้องหยิบ
                if (count > 0) // ถ้ามีจำนวนที่ต้องหยิบมากกว่า 0
                {
                    Debug.WriteLine($"{c} : {count}  บาท");
                    amount %= c; // ลดจำนวนเงินที่ยังเหลือ

                }
                if (amount == 0) // หากจำนวนเงินที่เหลือเป็น 0 ก็ไม่ต้องคำนวณต่อ
                    break;
            }
            ////sum += coin[i];
            ////Debug.WriteLine(sum);
            if (amount > 0)
                Debug.WriteLine(amount);
        }
        //    for (int i = 0; i < coin.Length; i++)
        //    {
        //        // หยิบเงินให้ได้จำนวนเงินที่ต้องการ
        //        while (amount >= coin[i])
        //        {
        //            Console.WriteLine($"{coin[i]}");
        //            amount -= coin[i];
        //        }

        //        // ถ้าจำนวนเงินที่เหลือเป็น 0 ก็ออกจากลูป
        //        if (amount == 0)
        //            break;
        //    }

        //    if (amount > 0)
        //        Console.WriteLine(amount);
        //}
        private void showName()
        {
            for(int i = 1;i <= 5; i++)
            {
                if (i % 2 <= 0) 
                {
                    Debug.WriteLine(i);
                } 
            }
        }
        private void showArray(int[] coin)
        {
            foreach (int c in coin)
            {
                Debug.WriteLine(c);
            }
        }
        private void showRun()
        {
            int[] weights = { 1, 2, 5, 6, 7 };
            int[] values = { 1, 6, 18, 22, 24 };
            int maxWeight = 11;

            // คำนวณอัตราส่วนมูลค่าต่อน้ำหนัก และเรียงลำดับสิ่งของตามอัตราส่วนจากมากไปน้อย
            var items = weights
             .Select((w, i) => new { Weight = w, Value = values[i], ValuePerWeight = (double)values[i] / w })
             .OrderByDescending(item => item.ValuePerWeight);

            double totalValue = 0;
            int currentWeight = 0;

            foreach (var item in items)
            {
                while (currentWeight + item.Weight <= maxWeight)
                {
                    currentWeight += item.Weight;
                    totalValue += item.Value;
                }

                if (currentWeight < maxWeight)
                {
                    int remainingWeight = maxWeight - currentWeight;
                    totalValue += item.ValuePerWeight * remainingWeight;
                    currentWeight = maxWeight;
                }

                if (currentWeight >= maxWeight) break;
            }

            Debug.WriteLine($"มูลค่ารวมสูงสุด: {totalValue}");
        }
        private void showRunNew()
        {
            int[] weights = { 100, 50, 45, 20, 10, 5 };
            int[] values = { 40, 35, 18, 14, 10, 2 };
            int maxWeight = 100;

            // คำนวณอัตราส่วนมูลค่าต่อน้ำหนัก และเรียงลำดับจากมากไปน้อย
            var items = weights
                .Select((w, i) => new { Weight = w, Value = values[i], Ratio = (double)values[i] / w, Index = i })
                .OrderByDescending(item => item.Ratio);

            double totalValue = 0;
            int currentWeight = 0;
            List<int> selectedItems = new List<int>();  // เพื่อเก็บรายการไอเทมที่เลือก

            foreach (var item in items)
            {
                // ถ้าน้ำหนักของไอเทมที่เลือกสามารถเพิ่มได้ในกระเป๋า
                while (currentWeight + item.Weight <= maxWeight)
                {
                    currentWeight += item.Weight;
                    totalValue += item.Value;
                    selectedItems.Add(item.Index);  // เก็บรหัสไอเทมที่เลือก

                    // แสดงข้อมูลเกี่ยวกับไอเทมที่เลือก
                    Debug.WriteLine($"หยิบไอเทม: {item.Index + 1} น้ำหนัก: {item.Weight} มูลค่า: {item.Value}");
                }

                // ถ้าน้ำหนักเต็มแล้ว (กรณีที่เหลือน้ำหนักไม่พอใส่ไอเทมเต็มชิ้น)
                if (currentWeight < maxWeight)
                {
                    int remainingWeight = maxWeight - currentWeight;
                    totalValue += item.Ratio * remainingWeight;
                    currentWeight = maxWeight;

                    // แสดงข้อมูลเกี่ยวกับไอเทมที่เลือกในกรณีที่เป็นเศษส่วน
                    Debug.WriteLine($"หยิบไอเทมส่วนหนึ่ง: {item.Index + 1} น้ำหนักที่หยิบ: {remainingWeight} มูลค่า: {item.Ratio * remainingWeight}");
                }

                // ถ้ากระเป๋ามีการใช้น้ำหนักเต็มแล้ว ไม่ต้องทำต่อ
                if (currentWeight >= maxWeight) break;
            }

            // แสดงมูลค่ารวม
            Debug.WriteLine($"มูลค่ารวมสูงสุด: {totalValue}");

            // แสดงรายการไอเทมที่เลือก
            Debug.WriteLine("รายการไอเทมที่หยิบมา: " + string.Join(", ", selectedItems.Select(index => index + 1)));
        }

        private void showHot()
        {
            int[,] grid = {
            { 1, 4, 5, 6 },
            { 3, 4, 1, 3 },
            { 3, 20, 10, 6 },
            { 8, 8, 2, 3 }
        };

            int maxSum = GetMaxSumGreedy(grid);
            Debug.WriteLine("ผลรวมสูงสุดที่เป็นไปได้โดยใช้ Greedy Algorithm: " + maxSum);
        }

        static int GetMaxSumGreedy(int[,] grid)
        {
            int row = 0, col = 0;
            int sum = grid[row, col];

            while (row < grid.GetLength(0) - 1 || col < grid.GetLength(1) - 1)
            {
                if (col == grid.GetLength(1) - 1) // ถ้าถึงขอบด้านขวาแล้ว ต้องลง
                {
                    row++;
                }
                else if (row == grid.GetLength(0) - 1) // ถ้าถึงขอบด้านล่างแล้ว ต้องไปทางขวา
                {
                    col++;
                }
                else if (grid[row + 1, col] > grid[row, col + 1]) // เปรียบเทียบค่าด้านล่างและขวา
                {
                    row++;
                }
                else
                {
                    col++;
                }

                sum += grid[row, col];
            }

            return sum;
        }
        private void Diamond()
        {
            int[] w = { 100, 50, 45, 20, 10, 5 };
            int[] p = { 40, 35, 18, 14, 10, 2 };
            int maxW = 11;

            double[] wp = new double[w.Length];
            int currentW = 0; int currentP = 0;

        }
    }
}
    