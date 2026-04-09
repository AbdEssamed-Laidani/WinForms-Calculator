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
        private void AppendButtonTextToScreen(Button button)
        {
            char[] Operation = { '+', '-', '×', '÷' };

            if (button != null)
            {
                if (Screen.Text[0] == '0' && Screen.Text.Length == 1)
                {
                    if (button != btnDecimalPoint &&
                        button != btnDivide &&
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
        private void ApplyOperationAtIndex(ref double result,ref List<string> list,ref int index,char operation)
        {
            switch(operation)
            {
                case '*':
                    result = Convert.ToDouble(list[index - 1]) * Convert.ToDouble(list[index + 1]);
                    break;
                case '/':
                    if (list[index + 1] == "0")
                        throw new DivideByZeroException();
                    result = Convert.ToDouble(list[index - 1]) / Convert.ToDouble(list[index + 1]);
                    break;
                case '%':
                    result = Convert.ToDouble(list[index - 1]) % Convert.ToDouble(list[index + 1]);
                    break;
            }
            list[index + 1] = result.ToString();
            list.RemoveRange(index - 1, 2);
            index -= 2;
        }
        private double CalculateMultiplicativeResult(string Item)
        {
            double result = default;
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
                            ApplyOperationAtIndex(ref result, ref ItemSplited, ref i,'*');
                        break;
                    case "÷":
                        if (i + 1 < ItemSplited.Count)
                            ApplyOperationAtIndex(ref result, ref ItemSplited, ref i, '/');
                        break;
                    case "%":
                        if (i + 1 < ItemSplited.Count)
                            ApplyOperationAtIndex(ref result, ref ItemSplited, ref i, '%');
                        break;
                    default:
                        break;
                }
            }


            return result;
        }
        public double CalculateExpressionResult(in string ScreenText)
        {
            string Pattern = @"(?=[+\-])";
            double result = 0;
            var ScreenAfterSplit = Regex.Split(ScreenText, Pattern)
                                        .Where(s => !string.IsNullOrWhiteSpace(s))
                                        .ToList();
            for (int i = 0; i < ScreenAfterSplit.Count; i++)
            {
                if (ScreenAfterSplit[i].Contains("×") || ScreenAfterSplit[i].Contains("÷") || ScreenAfterSplit[i].Contains("mod"))
                {
                    ScreenAfterSplit[i] = CalculateMultiplicativeResult(ScreenAfterSplit[i]).ToString();
                }
            }
            for (int i = 0; i < ScreenAfterSplit.Count; i++)
            {
                result += Convert.ToDouble(ScreenAfterSplit[i]);
            }

            return result;
        }
        private bool IsOperatorAppendAllowed(Button button)
        {
            char[] Operation = { '+', '-', '×', '÷' };
            if (Screen.TextLength >= 1)
            {
                foreach (var item in Operation)
                {
                    if (Screen.Text[Screen.Text.Length - 1] == item
                        || Screen.Text[Screen.Text.Length - 1].ToString() == "d")
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        private void AppendOperatorToScreen(Button button)
        {
            if (IsOperatorAppendAllowed(button))
                AppendButtonTextToScreen(button);
        }
        private void HandleScreenButtonInput(Button button)
        {
            switch (button.Name.ToString())
            {
                case "btnAddition":
                case "btnSubtract":
                case "btnMultiply":
                case "btnDivide":
                case "btnMODoperator":
                    AppendOperatorToScreen(button);
                    btnDecimalPoint.Tag = "1";
                    break;
                case "btnDecimalPoint":
                    if (btnDecimalPoint.Tag.ToString() == "1" && Screen.TextLength >= 1)
                    {
                        if (char.IsDigit(Screen.Text[Screen.TextLength - 1]))
                        {
                            AppendOperatorToScreen(button);
                            btnDecimalPoint.Tag = "0";
                        }
                    }
                    break;
                default:
                    AppendButtonTextToScreen(button);
                    break;
            }
        }
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            HandleScreenButtonInput(sender as Button);
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
                if (Screen.Text[Screen.Text.Length - 1] == '.')
                    btnDecimalPoint.Tag = "1";
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
            }

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            try
            {
                Screen.Text = CalculateExpressionResult(Screen.Text).ToString();
            }
            catch (Exception ex)
            {
                Screen.Text = ex.Message;
            }
        }
        private void Click_Button(object sender, EventArgs e)
        {
            HandleScreenButtonInput(sender as Button);
        }

        private frmSolveEquation _equationForm;
        private void btnSolveEquation_Click(object sender, EventArgs e)
        {
            if (_equationForm == null || _equationForm.IsDisposed)
            {
                _equationForm = new frmSolveEquation(this);
                _equationForm.Show();
            }
            else
                _equationForm.Focus();
        }

        private void btnCopyScreen_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Screen.Text);
        }

        private void btnPasteClipboard_Click(object sender, EventArgs e)
        {
            Screen.Text += Clipboard.GetText();
        }
    }
}
