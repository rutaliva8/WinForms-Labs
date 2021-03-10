using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Redux
{
    enum BaseMode
    {
        BASE2 = 2,
        BASE8 = 8,
        BASE10 = 10,
        BASE16 = 16,
    }

    enum CalculatorOperations
    {
        AND,
        OR,
        XOR
    }

    public partial class Form1 : Form
    {

        private delegate void ModeChange(BaseMode mode);
        private event ModeChange OnModeChange;

        private bool[] isValidNumber = new bool[2] { false, false };

        private CalculatorOperations operation = CalculatorOperations.AND;
        private BaseMode mode = BaseMode.BASE2;
        private BaseMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                OnModeChange?.Invoke(mode);
            }
        }

        private void CheckValid(bool where)
        {
            try
            {
                Convert.ToInt32((where ? num1 : num2).Text, (int)Mode);
                isValidNumber[where ? 0 : 1] = true;
            }
            catch
            {
                isValidNumber[where ? 0 : 1] = false;
            }
            finally
            {
                (where ? invalid1 : invalid2).Visible = !isValidNumber[where ? 0 : 1];
            }
        }

        private string ConvertBase(string number, BaseMode fromBase, BaseMode toBase) => Convert.ToString(Convert.ToInt32(number, (int)fromBase), (int)toBase);

        private string ChangeBase(string number, BaseMode toBase, int idx)
        {

            if (String.IsNullOrEmpty(number) || mode == toBase || !isValidNumber[idx])
                return number;
            return ConvertBase(number, Mode, toBase);
        }

        private string ValidateInput(string input)
        {
            string valid = String.Empty;
            foreach (char bit in input)
            {
                if (Char.IsDigit(bit))
                {
                    valid += bit;
                }
            }
            return valid;
        }

        public Form1()
        {
            InitializeComponent();

            OnModeChange += (BaseMode mode) =>
            {
                base_label.Text = $"Current base: {((int)mode).ToString()}";
                CheckValid(true);
                CheckValid(false);
            };
            Mode = BaseMode.BASE2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void base_btn_Click(object sender, EventArgs e)
        {
            // Ew... Fix that later maybe?..
            switch (mode)
            {
                case BaseMode.BASE2:
                    Mode = BaseMode.BASE8;
                    break;
                case BaseMode.BASE8:
                    Mode = BaseMode.BASE10;
                    break;
                case BaseMode.BASE10:
                    Mode = BaseMode.BASE16;
                    break;
                default:
                    Mode = BaseMode.BASE2;
                    break;
            }
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            num1.Text = ValidateInput(num1.Text);
            CheckValid(true);
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            num2.Text = ValidateInput(num2.Text);
            CheckValid(false);
        }

        private void to2_btn_Click(object sender, EventArgs e)
        {
            num1.Text = ChangeBase(num1.Text.ToString(), BaseMode.BASE2, 0);
            num2.Text = ChangeBase(num2.Text.ToString(), BaseMode.BASE2, 1);

            Mode = BaseMode.BASE2;
        }

        private void to10_btn_Click(object sender, EventArgs e)
        {
            num1.Text = ChangeBase(num1.Text.ToString(), BaseMode.BASE10, 0);
            num2.Text = ChangeBase(num2.Text.ToString(), BaseMode.BASE10, 1);

            Mode = BaseMode.BASE10;
        }

        private void to8_btn_Click(object sender, EventArgs e)
        {
            num1.Text = ChangeBase(num1.Text.ToString(), BaseMode.BASE8, 0);
            num2.Text = ChangeBase(num2.Text.ToString(), BaseMode.BASE8, 1);

            Mode = BaseMode.BASE8;
        }

        private void to16_btn_Click(object sender, EventArgs e)
        {
            num1.Text = ChangeBase(num1.Text.ToString(), BaseMode.BASE16, 0);
            num2.Text = ChangeBase(num2.Text.ToString(), BaseMode.BASE16, 1);

            Mode = BaseMode.BASE16;
        }

        private void equals_btn_Click(object sender, EventArgs e)
        {
            string output = String.Empty;

            try
            {
                int val1 = Convert.ToInt32(ChangeBase(num1.Text, BaseMode.BASE10, 0));
                int val2 = Convert.ToInt32(ChangeBase(num2.Text, BaseMode.BASE10, 1));
                switch (operation)
                {
                    case CalculatorOperations.AND:
                        output = ConvertBase((val1 & val2).ToString(), BaseMode.BASE10, Mode);
                        break;
                    case CalculatorOperations.OR:
                        output = ConvertBase((val1 | val2).ToString(), BaseMode.BASE10, Mode);
                        break;
                    case CalculatorOperations.XOR:
                        output = ConvertBase((val1 ^ val2).ToString(), BaseMode.BASE10, Mode);
                        break;
                }
            } catch { };
            output_field.Text = output;
        }

        private void and_btn_Click(object sender, EventArgs e)
        {
            operation_label.Text = "*";
            operation = CalculatorOperations.AND;
        }

        private void or_btn_Click(object sender, EventArgs e)
        {
            operation_label.Text = "+";
            operation = CalculatorOperations.OR;
        }

        private void xor_btn_Click(object sender, EventArgs e)
        {
            operation_label.Text = "^";
            operation = CalculatorOperations.XOR;
        }

        private void operation_label_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            output_field.Text = String.Empty;
        }

        private void not_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = Convert.ToInt32(ChangeBase(num1.Text, BaseMode.BASE10, 0));
                int val2 = Convert.ToInt32(ChangeBase(num2.Text, BaseMode.BASE10, 1));

                num1.Text = ConvertBase((~val1).ToString(), BaseMode.BASE10, Mode);
                num2.Text = ConvertBase((~val2).ToString(), BaseMode.BASE10, Mode);
            }
            catch { };
        }
    }
}
