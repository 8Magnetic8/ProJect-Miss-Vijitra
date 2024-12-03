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
    public partial class Diamond : Form
    {
        public Diamond()
        {
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            String values = textBox1.Text;
            String[] dataw = values.Split(',');
            int[] w = new int[dataw.Length];
            for (int i = 0; i < dataw.Length; i++)
            {
                w[i] = int.Parse(dataw[i]);
            }

            String weights = textBox2.Text;
            String[] datap = weights.Split(',');
            int[] p = new int[datap.Length];
            for (int i = 0; i < datap.Length; i++)
            {
                p[i] = int.Parse(datap[i]);
            }

            // รับค่า maxWeight จากการป้อนใน textBox3
            int maxWeight = int.Parse(textBox3.Text);

            // สร้างอาร์เรย์ wp สำหรับอัตราส่วนมูลค่าต่อน้ำหนัก
            double[] wp = new double[w.Length];
            for (int i = 0; i < wp.Length; i++)
            {
                wp[i] = (double)p[i] / w[i];
            }

            // เรียงลำดับ wp และสลับค่าใน w และ p ให้ตรงกันด้วย
            for (int i = 0; i < wp.Length - 1; i++)
            {
                for (int j = 0; j < wp.Length - i - 1; j++)
                {
                    if (wp[j] < wp[j + 1])
                    {
                        // สลับค่าใน wp
                        double tempRatio = wp[j];
                        wp[j] = wp[j + 1];
                        wp[j + 1] = tempRatio;

                        // สลับค่าใน w
                        int tempWeight = w[j];
                        w[j] = w[j + 1];
                        w[j + 1] = tempWeight;

                        // สลับค่าใน p
                        int tempValue = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = tempValue;
                    }
                }
            }

            // คำนวณการเลือกไอเท็มเพื่อให้ได้มูลค่าสูงสุดที่น้ำหนักไม่เกินความจุของกระเป๋า
            double totalValue = 0;
            int currentWeight = 0;
            listBox1.Items.Clear(); // ล้างข้อมูลเก่าใน ListBox ก่อน

            for (int i = 0; i < wp.Length; i++)
            {
                if (currentWeight + w[i] <= maxWeight)
                {
                    // หยิบไอเท็มทั้งชิ้นได้
                    currentWeight += w[i];
                    totalValue += p[i];
                    listBox1.Items.Add($"Item {i + 1}: น้ำหนัก = {w[i]}, มูลค่า = {p[i]}, อัตราส่วนมูลค่าต่อน้ำหนัก = {wp[i]:0.00}");
                }
                else
                {
                    // ถ้าหยิบไอเท็มทั้งหมดไม่ได้ แต่สามารถหยิบบางส่วนได้
                    int remainingWeight = maxWeight - currentWeight;
                    totalValue += wp[i] * remainingWeight;
                    currentWeight = maxWeight;
                    listBox1.Items.Add($"Item {i + 1} (บางส่วน): น้ำหนัก = {remainingWeight}, มูลค่า = {wp[i] * remainingWeight:0.00}");
                    break;
                }
            }

            // แสดงมูลค่ารวมสูงสุดใน ListBox
            listBox1.Items.Add($"มูลค่ารวมสูงสุดที่ใส่ในกระเป๋าได้: {totalValue:0.00}");
        }
    }
}
