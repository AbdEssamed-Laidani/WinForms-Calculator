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
    public partial class frmSolveEquation : Form
    {

        private double Delta;
        private double A;
        private double B;
        private double C;
        private double X1;
        private double X2;
        private enum NumberOfSolution
        {
            None = 0,
            OneSol = 1,
            TwoSol = 2,
        }
        Form1 form;
        public frmSolveEquation(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }
        private double GetDelta()
        {
           
                A = GetLeadingCoeffcient();
                B = GetLinearCoeffcient();
                C = GetConstantTerm();
            
            
            return B * B - 4 * A * C;
        }
        
        private double GetLeadingCoeffcient()
        {

            return form.CalculateFinalResult(LeadingCoefficient.Text.Substring(4, LeadingCoefficient.Text.Length - 4));
        }
        private double GetLinearCoeffcient()
        {

            return form.CalculateFinalResult(LinearCoeffcient.Text.Substring(4, LinearCoeffcient.Text.Length - 4));
           
        }
        private double GetConstantTerm()
        {

            return form.CalculateFinalResult(ConstantTerm.Text.Substring(4, ConstantTerm.Text.Length - 4));
           
        }
        private NumberOfSolution GetSolution(double Delta)
        {
            if (Delta > 0)
            {
                X1 = (-B - Math.Sqrt(Delta)) / (2 * A);
                X2 = (-B + Math.Sqrt(Delta)) / (2 * A);
                return NumberOfSolution.TwoSol;
            }
            else if (Delta == 0)
            {
                X1 = -B / (2 * A);
                return NumberOfSolution.OneSol;
            }
            return NumberOfSolution.None;
        }
        private double GetFirstSolution()
        {
            return X1;
        }
        private double GetSecondSolution()
        {
            return X2;
        }
        
        private void UpdateCoeffcient(in string ButtonText)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            
            if (button != null)
            {
                if (button == rbA)
                {
                    LeadingCoefficient.Text += ButtonText;
                }
                else if (button == rbB)
                {
                    LinearCoeffcient.Text += ButtonText;
                }
                else
                {
                    ConstantTerm.Text += ButtonText;
                }
            }
            
        }
        private void Click_Button(object sender, EventArgs e)
        {
            if (((Button)sender) == btnDecimalPoint)
            {
                if (btnDecimalPoint.Tag.ToString() == "1")
                {
                    btnDecimalPoint.Tag = "0";
                    UpdateCoeffcient(((Button)sender).Text);
                }
                else
                    return;
            }
            else
                UpdateCoeffcient(((Button)sender).Text);
        }
        private string ClearScreen(string Target)
        {
            while (Target.Length > 4)
                Target = DecreaseText(Target);
            return Target;
        }
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (button != null)
            {
                if (button == rbA)
                    LeadingCoefficient.Text = ClearScreen(LeadingCoefficient.Text);
                else if (button == rbB)
                    LinearCoeffcient.Text = ClearScreen(LinearCoeffcient.Text);
                else
                    ConstantTerm.Text = ClearScreen(ConstantTerm.Text);
            }
        }
        private string DecreaseText(string Target)
        {
            //we need to ensure that the target length is over 4 characters to keep the format "a = "...
            if (Target.Length > 4)
            {
                return Target.Remove(Target.Length - 1);
            }
            else 
                return Target;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (button != null)
            {
                if (button == rbA)
                    LeadingCoefficient.Text = DecreaseText(LeadingCoefficient.Text);
                else if (button == rbB)
                    LinearCoeffcient.Text = DecreaseText(LinearCoeffcient.Text);
                else
                    ConstantTerm.Text = DecreaseText(ConstantTerm.Text);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {

            try
            {
                Delta = GetDelta();
            }
            catch(Exception ex)
            {
                SolutionScreen.Text = ex.Message;
                return;
            }

            switch (GetSolution(Delta))
            {
                case NumberOfSolution.TwoSol:
                    SolutionScreen.Text = "X1 = " + GetFirstSolution() +
                        Environment.NewLine + Environment.NewLine + "X2 = " + GetSecondSolution();
                    break;
                case NumberOfSolution.OneSol:
                    SolutionScreen.Text = "X = " + GetFirstSolution();
                    break;
                case NumberOfSolution.None:
                    SolutionScreen.Text = "No Real Solution";
                    break;
                default:
                    SolutionScreen.Text = "No Real Solution";
                    break;
            }
        }

        private void btnChangeSign_Click(object sender, EventArgs e)
        {
            foreach (var item in gbNumbers.Controls.OfType<Button>())
            {
                if (item.Text.Length > 1 ? Char.IsDigit(item.Text, 1)
                    : Char.IsDigit(item.Text, 0))
                {
                    if (item != btnNumber0 && item != btnDecimalPoint)
                    item.Text = (-1 * Convert.ToInt16(item.Text)).ToString();
                }
            }
            if (btnChangeSign.Tag.ToString() == "negative")
            {
                btnChangeSign.Text = "To Possitive";
                btnChangeSign.Tag = "possitive";
            }
            else
            {
                btnChangeSign.Text = "To Negative";
                btnChangeSign.Tag = "negative";
            }

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var rbutton = groupBox1.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();

            if (rbutton == rbA)
                Clipboard.SetText(GetLeadingCoeffcient().ToString());
            else if (rbutton == rbB)
                Clipboard.SetText(GetLinearCoeffcient().ToString());
            else
                Clipboard.SetText(GetConstantTerm().ToString());
        }

        private void btnPasteClipboard_Click(object sender, EventArgs e)
        {
            UpdateCoeffcient(Clipboard.GetText());
        }
    }
}
