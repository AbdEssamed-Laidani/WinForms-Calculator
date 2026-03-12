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
    public partial class frmSolveEquation : Form
    {
        public frmSolveEquation()
        {
            InitializeComponent();
        }
        private void UpdateCoeffcient(in string ButtonText)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            
            if (button != null)
            {
                if (button == rbA)
                    LeadingCoefficient.Text += ButtonText;
                else if (button == rbB)
                    LinearCoeffcient.Text += ButtonText;
                else
                    ConstantTerm.Text += ButtonText;
            }
            
        }
        private void Click_Button(object sender, EventArgs e)
        {
            UpdateCoeffcient(((Button)sender).Text);
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            UpdateCoeffcient(string.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RadioButton button = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (button != null)
            {
                if (button == rbA)
                    LeadingCoefficient.Text = LeadingCoefficient.Text.Substring(0,LeadingCoefficient.Text.Length - 1);
                else if (button == rbB)
                    LinearCoeffcient.Text = LinearCoeffcient.Text.Substring(0, LinearCoeffcient.Text.Length - 1);
                else
                    ConstantTerm.Text = ConstantTerm.Text.Substring(0,ConstantTerm.Text.Length - 1);
            }
        }
    }
}
