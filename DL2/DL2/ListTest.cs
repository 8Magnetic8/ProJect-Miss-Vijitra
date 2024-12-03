using System;
using System.Collections;
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
    public partial class ListTest : Form
    {
        public ListTest()
        {
            InitializeComponent();
            //initiaValue();
            //stackDemo();
            queueDemo();
        }
        private void initiaValue()
        {
            var list = new List<int>();
            //list.Add((50, 40));
            //list.Add((10, 9));
            //list.Add((50, 7));
            //list.Add((80,8));
            //list.Add((100, 2));
            //list.Add((30, 5));
            list.Add(50);
            list.Add(10);
            list.Add(50);
            list.Add(80);
            list.Add(100);
            list.Add(30);
            for (int i = 0; i < list.Count; i++) 
            {
                System.Diagnostics.Debug.WriteLine(list[i]);

                int a = 10;
                int b = 50;
                int c = 100;

                //int tmp = a;
                //a=b; 
                //b=tmp;
                swap(ref a, ref b);
                System.Diagnostics.Debug.WriteLine(a + ", " + b + ", " + c);
                //tmp = b;
                //b = c;
                //c = tmp;
                swap(ref b, ref c);
                System.Diagnostics.Debug.WriteLine(a + ", " + b + ", " + c);
            }
            //    //list.RemoveAt(50);
            //    list.Sort();
            //    list.Reverse();
            //}
            //foreach (int data in list)
            //{
            //    Console.WriteLine(data);
            //}
        }
        private void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        private void stackDemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(50);
            stack.Push(80);
            stack.Push(100);
            stack.Push(30);
        foreach (int data in stack) 
                System.Diagnostics.Debug.WriteLine(data);
            stack.Pop();
        foreach(int data in stack)
                System.Diagnostics.Debug.WriteLine(data);
        }   
        private void queueDemo()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(50);
            queue.Enqueue(80);
            queue.Enqueue(100);
            queue.Enqueue(30);
            foreach (int data in queue)
                System.Diagnostics.Debug.WriteLine(data);
            queue.Dequeue();
            foreach (int data in queue)
                System.Diagnostics.Debug.WriteLine(data);
        }
    }
}
