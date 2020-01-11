using System;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        string sign;
        double operand1;
        double operand2;
        bool calculated;
        public Calculator()
        {
            InitializeComponent();
            txtBox.Enabled = false;
            txtBox.Text = "0";
            LblFormular.Select();
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd0.Text;
            else
                txtBox.Text = txtBox.Text + cmd0.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd1.Text;
            else
                txtBox.Text = txtBox.Text + cmd1.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd2.Text;
            else
                txtBox.Text = txtBox.Text + cmd2.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd3.Text;
            else
                txtBox.Text = txtBox.Text + cmd3.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd4.Text;
            else
                txtBox.Text = txtBox.Text + cmd4.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd5.Text;
            else
                txtBox.Text = txtBox.Text + cmd5.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd6.Text;
            else
                txtBox.Text = txtBox.Text + cmd6.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd7.Text;
            else
                txtBox.Text = txtBox.Text + cmd7.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd8.Text;
            else
                txtBox.Text = txtBox.Text + cmd8.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || calculated == true)
                txtBox.Text = cmd9.Text;
            else
                txtBox.Text = txtBox.Text + cmd9.Text;
            if (LblFormular.Text.Contains("="))
                LblFormular.Text = "";
            calculated = false;
        }

        private void cmdDot_Click(object sender, EventArgs e)
        {
            if (calculated == true)
            {
                txtBox.Text = "0.";
                LblFormular.Text = "";
                calculated = false;
            }
            else
            {
                string tempText = txtBox.Text;
                int txtBoxLength = txtBox.TextLength;
                int flag = 0;
                for (int i = 0; i < txtBoxLength; i++)
                {
                    if (tempText[i].ToString() == ".")
                    {
                        flag = 1;
                        break;
                    }
                    else
                        flag = 0;
                }
                if (flag == 0)
                {
                    txtBox.Text = tempText + ".";
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            LblFormular.Text = "";
            operand1 = 0;
            operand2 = 0;
            sign = "";
            cmdPercentage.Enabled = true;
            calculated = false;
        }

        private void cmdNegPos_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.StartsWith("-"))
                txtBox.Text = txtBox.Text.Substring(1);
            else
                txtBox.Text = "-" + txtBox.Text;
        }

        private void cmdPercentage_Click(object sender, EventArgs e)
        {
            if (operand1 == 0)
                txtBox.Text = (double.Parse(txtBox.Text) / 100).ToString();
            else
                txtBox.Text = (operand1 * (double.Parse(txtBox.Text) / 100)).ToString();
        }

        private void cmdDel_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length == 1 || txtBox.Text == "")
                txtBox.Text = "0";
            else
                txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1);
            if (txtBox.Text == "" || txtBox.Text == "0")
                LblFormular.Text = "";
            if (sign == "/")
                cmdPercentage.Enabled = true;
        }

        private void cmdDivide_Click(object sender, EventArgs e)
        {
            cmdPercentage.Enabled = false;
            sign = "/";
            double parsedResult;
            if(double.TryParse((txtBox.Text), out parsedResult))
                operand1 = parsedResult;
            if (txtBox.Text == "0.")
                LblFormular.Text = 0 + sign;
            else if (txtBox.Text == "")
                LblFormular.Text = LblFormular.Text;
            else
                LblFormular.Text = txtBox.Text + sign;
            txtBox.Text = "";
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            sign = "x";
            double parsedResult;
            if (double.TryParse((txtBox.Text), out parsedResult))
                operand1 = parsedResult;
            if (txtBox.Text == "0.")
                LblFormular.Text = 0 + sign;
            else if (txtBox.Text == "")
                LblFormular.Text = LblFormular.Text;
            else
                LblFormular.Text = txtBox.Text + sign;
            txtBox.Text = "";
        }

        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            double parsedResult;
            if (double.TryParse((txtBox.Text), out parsedResult))
                operand1 = parsedResult;
            if (txtBox.Text == "0.")
                LblFormular.Text = 0 + sign;
            else if (txtBox.Text == "")
                LblFormular.Text = LblFormular.Text;
            else
                LblFormular.Text = txtBox.Text + sign;
            txtBox.Text = "";
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            double parsedResult;
            if (double.TryParse((txtBox.Text), out parsedResult))
                operand1 = parsedResult;
            if (txtBox.Text == "0.")
                LblFormular.Text = 0 + sign;
            else if (txtBox.Text == "")
                LblFormular.Text = LblFormular.Text;
            else
                LblFormular.Text = txtBox.Text + sign;
            txtBox.Text = "";
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            if (calculated == false)
            {
                if (txtBox.Text == ".")
                {
                    operand2 = 0;
                    txtBox.Text = "0";
                }
                else if (txtBox.Text == "0" || txtBox.Text == "")
                    operand2 = 0;
                else
                    operand2 = double.Parse(txtBox.Text);
            }
            else operand1 = double.Parse(txtBox.Text);
            if (sign == "+")
                txtBox.Text = (operand1 + operand2).ToString();
            else if (sign == "-")
                txtBox.Text = (operand1 - operand2).ToString();
            else if (sign == "x")
                txtBox.Text = (operand1 * operand2).ToString();
            else if (sign == "/")
            {
                cmdPercentage.Enabled = true;
                if (operand2 == 0)
                    LblFormular.Text = "Cannot Divide by Zero";
                else
                    txtBox.Text = (operand1 / operand2).ToString();
            }
            if(calculated == false)
            {
                if ((operand2 == 0) && (sign == "/"))
                    LblFormular.Text = LblFormular.Text;
                else
                    LblFormular.Text = LblFormular.Text + operand2 + "=";
            }
            else
                LblFormular.Text = operand1 + sign + operand2 + "=";
            calculated = true;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                double parsedResult;
                bool validParse;
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                System.Globalization.NumberStyles style = System.Globalization.NumberStyles.AllowThousands
                    | System.Globalization.NumberStyles.AllowLeadingSign
                    | System.Globalization.NumberStyles.AllowDecimalPoint;
                validParse = double.TryParse(txtBox.Text, style, culture, out parsedResult);
                if (cmdDot.Focused)
                {
                    txtBox.Text = txtBox.Text;
                }
                else if (txtBox.Text.Contains("."))
                {
                    txtBox.Text = String.Format(culture, "{0:0.###}", parsedResult);
                }
                else
                {
                    txtBox.Text = String.Format(culture, "{0:N0}", parsedResult);
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
