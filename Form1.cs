using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void ChangeNumber(Button button)
        {
            char[] Operation = { '+', '-', '×', '÷' };

            if (button != null)
            {
                if (Screen.Text[0] == '0' && Screen.Text.Length == 1)
                {
                    if (button != btnDecimalPoint &&
                        button != btnDevid &&
                        button != btnMODoperator &&
                        button != btnMultiply)
                        Screen.Text = button.Text.ToString();
                    else
                        Screen.Text += button.Text.ToString();
                }
                else
                    Screen.Text += button.Text.ToString();
            }
        }
        private decimal CalculateMultiplyAndDevidByOrder(string Item)
        {
            decimal result = default;
            string pattern = @"([\×\÷\%])";
            var ItemSplited = Regex.Split(Item.Replace("mod", "%"), pattern)
                            .Where(s => !string.IsNullOrWhiteSpace(s))
                            .ToList();

            for (int i = 0; i < ItemSplited.Count; i++)
            {
                switch (ItemSplited[i])
                {
                    case "×":
                        if (i + 1 < ItemSplited.Count)
                        {
                            result = Convert.ToDecimal(ItemSplited[i - 1]) * Convert.ToDecimal(ItemSplited[i + 1]);
                            ItemSplited[i + 1] = result.ToString();
                            ItemSplited.RemoveRange(i - 1, 2);
                            i-=2;
                        }
                        break;
                    case "÷":
                        if (i + 1 < ItemSplited.Count)
                        {
                            result = Convert.ToDecimal(ItemSplited[i - 1]) / Convert.ToDecimal(ItemSplited[i + 1]);
                            ItemSplited[i + 1] = result.ToString();
                            ItemSplited.RemoveRange(i - 1, 2);
                            i -= 2;
                        }
                        break;
                    case "%":
                        if (i + 1 < ItemSplited.Count)
                        {
                            result = Convert.ToDecimal(ItemSplited[i - 1]) % Convert.ToDecimal(ItemSplited[i + 1]);
                            ItemSplited[i + 1] = result.ToString();
                            ItemSplited.RemoveRange(i - 1, 2);
                            i -= 2;
                        }
                        break;
                    default:
                        break;
                }
            }


            return result;
        }
        protected decimal CalculateFinalResult()
        {
            string Pattern = @"(?=[+\-])";
            decimal result = 0;
            var ScreenAfterSplit = Regex.Split(Screen.Text, Pattern)
                                        .Where(s => !string.IsNullOrWhiteSpace(s))
                                        .ToList();
            for (int i = 0; i < ScreenAfterSplit.Count; i++)
            {
                if (ScreenAfterSplit[i].Contains("×") || ScreenAfterSplit[i].Contains("÷") || ScreenAfterSplit[i].Contains("mod"))
                {
                    ScreenAfterSplit[i] = CalculateMultiplyAndDevidByOrder(ScreenAfterSplit[i]).ToString();
                }
            }
            for (int i = 0; i < ScreenAfterSplit.Count; i++)
            {
                result += Convert.ToDecimal(ScreenAfterSplit[i]);
            }

            return result;
        }
        private void PerformOperation(Button button)
        {
            char[] Operation = { '+', '-', '×', '÷' };
            if (Screen.TextLength >= 1)
            {
                foreach (var item in Operation)
                {
                    if (Screen.Text[Screen.Text.Length - 1] == item
                        || Screen.Text[Screen.Text.Length - 1].ToString() == "d")
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
                    btnDecimalPoint.Tag = "1";
                    break;
                case "btnSubtract":
                    PerformOperation(btnSubtract);
                    btnDecimalPoint.Tag = "1";
                    break;
                case "btnMultiply":
                    PerformOperation(btnMultiply);
                    btnDecimalPoint.Tag = "1";
                    break;
                case "btnDevid":
                    PerformOperation(btnDevid);
                    btnDecimalPoint.Tag = "1";
                    break;
                case "btnMODoperator":
                    PerformOperation(btnMODoperator);
                    btnDecimalPoint.Tag = "1";
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
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                Screen.Text = CalculateFinalResult().ToString();
            }
            catch (Exception ex)
            {
                Screen.Text = ex.Message;
            }
        }
        private void Click_Button(object sender, EventArgs e)
        {
            ChangeScreen(sender as Button);
        }

        private void btnSolveEquation_Click(object sender, EventArgs e)
        {
            frmSolveEquation form = new frmSolveEquation();
            form.ShowDialog();   
        }
    }
}
