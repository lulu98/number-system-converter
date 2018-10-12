using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSystemConversion
{
    public partial class Form1 : Form
    {
        string input = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 16; i++)
            {
                inputBase.Items.Add(i);
                outputBase.Items.Add(i);
            }
            inputBase.SelectedItem = 10;
            outputBase.SelectedItem = 10;
        }

        private void ResetPage()
        {
            inputBox.Text = "0";
            resultBox.Text = "0";
        }

        private void UpdatePage()
        {
            if (input == "")
            {
                inputBox.Text = "0";
            }
            else
            {
                inputBox.Text = input;
            }
            resultBox.Text = NumberSystemConversion.XAryToYAry(inputBox.Text,int.Parse(inputBase.SelectedItem.ToString()),int.Parse(outputBase.SelectedItem.ToString()));
        }

        private void AddNewCharToInput(string newChar)
        {
            if (newChar.Length == 1 && NumberSystemConversion.GetRealValue(newChar) < int.Parse(inputBase.SelectedItem.ToString()))
            {
                input += newChar;
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("1");
            UpdatePage();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("2");
            UpdatePage();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("3");
            UpdatePage();
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("4");
            UpdatePage();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("5");
            UpdatePage();
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("6");
            UpdatePage();
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("7");
            UpdatePage();
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("8");
            UpdatePage();
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("9");
            UpdatePage();
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                input += "0";
            }
            UpdatePage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
            }
            UpdatePage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            input = "";
            UpdatePage();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("A");
            UpdatePage();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("B");
            UpdatePage();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("C");
            UpdatePage();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("D");
            UpdatePage();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("E");
            UpdatePage();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            AddNewCharToInput("F");
            UpdatePage();
        }

        private void outputBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (input != "")
            {
                UpdatePage();
            }
        }

        private void inputBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (input == "")
            {
                inputBox.Text = "0";
            }
            else
            {
                inputBox.Text = NumberSystemConversion.XAryToYAry(resultBox.Text, int.Parse(outputBase.SelectedItem.ToString()), int.Parse(inputBase.SelectedItem.ToString()));
                input = inputBox.Text;
            }
        }
    }
}
