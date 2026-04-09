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
        private Form1 form;
        public frmSolveEquation(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }
        private double GetDiscriminant()
        {
           
                A = GetLeadingCoefficient();
                B = GetLinearCoefficient();
                C = GetConstantTerm();
            
            
            return B * B - 4 * A * C;
        }
        
        private double GetLeadingCoefficient()
        {

            return form.CalculateExpressionResult(LeadingCoefficient.Text.Substring(4, LeadingCoefficient.Text.Length - 4));
        }
        private double GetLinearCoefficient()
        {

            return form.CalculateExpressionResult(LinearCoeffcient.Text.Substring(4, LinearCoeffcient.Text.Length - 4));
           
        }
        private double GetConstantTerm()
        {

            return form.CalculateExpressionResult(ConstantTerm.Text.Substring(4, ConstantTerm.Text.Length - 4));
           
        }
        private NumberOfSolution GetSolutionCount(double Delta)
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

        private void UpdateCoefficient(in string ButtonText, bool CheckDecimalPoint = false)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();

            if (button != null)
            {
                if (button == rbA)
                {
                    if (CheckDecimalPoint && LeadingCoefficient.Text.Contains('.'))
                        return;
                    LeadingCoefficient.Text += ButtonText;
                }
                else if (button == rbB)
                {
                    if (CheckDecimalPoint && LinearCoeffcient.Text.Contains('.'))
                        return;
                    LinearCoeffcient.Text += ButtonText;
                }
                else
                {
                    if (CheckDecimalPoint && ConstantTerm.Text.Contains('.'))
                        return;
                    ConstantTerm.Text += ButtonText;
                }
            }

        }
        private void Click_Button(object sender, EventArgs e)
        {
            if (((Button)sender) == btnDecimalPoint)
                UpdateCoefficient(((Button)sender).Text, CheckDecimalPoint: true);
            else
                UpdateCoefficient(((Button)sender).Text);
        }
        private string ClearCoefficientValue(string Target)
        {
            while (Target.Length > 4)
                Target = DeleteLastCharacter(Target);
            return Target;
        }
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (button != null)
            {
                if (button == rbA)
                    LeadingCoefficient.Text = ClearCoefficientValue(LeadingCoefficient.Text);
                else if (button == rbB)
                    LinearCoeffcient.Text = ClearCoefficientValue(LinearCoeffcient.Text);
                else
                    ConstantTerm.Text = ClearCoefficientValue(ConstantTerm.Text);
            }
        }
        private string DeleteLastCharacter(string Target)
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
                    LeadingCoefficient.Text = DeleteLastCharacter(LeadingCoefficient.Text);
                else if (button == rbB)
                    LinearCoeffcient.Text = DeleteLastCharacter(LinearCoeffcient.Text);
                else
                    ConstantTerm.Text = DeleteLastCharacter(ConstantTerm.Text);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {

            try
            {
                Delta = GetDiscriminant();
            }
            catch(Exception ex)
            {
                SolutionScreen.Text = ex.Message;
                return;
            }
            if (A == 0)
            {
                SolutionScreen.Text = "Not a Quadratic Equation";
                return;
            }
            switch (GetSolutionCount(Delta))
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
                Clipboard.SetText(GetLeadingCoefficient().ToString());
            else if (rbutton == rbB)
                Clipboard.SetText(GetLinearCoefficient().ToString());
            else
                Clipboard.SetText(GetConstantTerm().ToString());
        }

        private void btnPasteClipboard_Click(object sender, EventArgs e)
        {
            UpdateCoefficient(Clipboard.GetText());
        }
    }
}
