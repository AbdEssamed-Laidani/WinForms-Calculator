using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Result = default;
        private void ChangeNumber(Button button)
        {
            char[] Operation = { '+', '-', '×', '÷' };

            if (button != null)
            {
                if (Screen.Text[0] == '0' && Screen.Text.Length == 1)
                {
                    if (button != btnDecimalPoint &&
                        button != btnAddition &&
                        button != btnSubtract &&
                        button != btnDevid &&
                        button != btnMultiply)
                        Screen.Text = button.Text.ToString();
                    else
                        Screen.Text += button.Text.ToString();
                }
                else
                    Screen.Text += button.Text.ToString();
            }
        }
        private void PerformOperation(Button button)
        {
            char[] Operation = { '+', '-', '×', '÷' };
            if (Screen.TextLength >= 1)
            {
                foreach (var item in Operation)
                {
                    if (Screen.Text[Screen.Text.Length - 1] == item)
                    {
                        return;
                    }
                }
                ChangeNumber(button);
            }
        }
        private void ChangeScreen(Button button)
        {
            switch (button.Name.ToString())
            {
                case "btnAddition":
                    PerformOperation(btnAddition);
                    break;
                case "btnSubtract":
                    PerformOperation(btnSubtract);
                    break;
                case "btnMultiply":
                    PerformOperation(btnMultiply);
                    break;
                case "btnDevid":
                    PerformOperation(btnDevid);
                    break;
                case "btnDecimalPoint":
                    if (btnDecimalPoint.Tag.ToString() == "1")
                    {
                        PerformOperation(btnDecimalPoint);
                        btnDecimalPoint.Tag = "0";
                    }
                    break;
                default:
                    ChangeNumber(button);
                    break;
            }
        }
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            ChangeScreen(sender as Button);
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            btnDecimalPoint.Tag = "1";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length >= 1)
            {
                if (Screen.Text.Length == 1)
                {
                    btnClearScreen_Click(sender, e);
                    return;
                }
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
            }

        }

        private void Click_Button(object sender, EventArgs e)
        {
            ChangeScreen(sender as Button);
        }
    }
}
