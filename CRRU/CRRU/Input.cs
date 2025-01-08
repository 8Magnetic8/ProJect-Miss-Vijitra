using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRRU
{
    internal class Input
    {
        string UserInput = "";
        public Input(string variableName) 
        {
            inputBox inputBox = new inputBox();
            inputBox.label1.Text = "ป้อนค่า" + variableName;
            inputBox.ShowDialog();
            UserInput = inputBox.UserInput;
        }
        public string getData()
        {
            return UserInput;
        }
    }
}
