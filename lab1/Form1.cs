using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    enum BaseMode
    {
        BASE2 = 2,
        BASE8 = 8,
        BASE10 = 10,
        BASE16 = 16,
    }

    struct Operation
    {
        int num1;
        int? num2;
        char operation;
        int result;
        
        Operation(int num1, int? num2, char operation)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.operation = operation;

            switch (this.operation)
            {
                case '&':
                    result = num1 & (int)num2;
                    break;
                case '|':
                    result = num1 | (int)num2;
                    break;
                case '^':
                    result = num1 ^ (int)num2;
                    break;
                case '-':
                    result = ~num1;
                    break;
                default:
                    result = 0;
                    break;
            }
        }
    }

    public partial class Form1 : Form
    {
        private delegate int CalculatorOperation(int num1, int num2);

        private delegate void ModeChange(BaseMode mode);
        private event ModeChange OnModeChange;

        private bool isValidNumber = false;

        private BaseMode mode = BaseMode.BASE2;
        private BaseMode Mode {
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

        private void CheckIsValid()
        {
            try
            {
                Convert.ToInt32(output_field.Text, (int)Mode);
                isValidNumber = true;
            }
            catch
            {
                isValidNumber = false;
            }
            finally
            {
                error_label.Visible = !isValidNumber;
            }
        }

        private void ChangeBase(string number, BaseMode toBase)
        {
            if (String.IsNullOrEmpty(number) || mode == toBase || !isValidNumber)
                return;
            output_field.Text = Convert.ToString(Convert.ToInt32(number, (int)Mode), (int)toBase);
            Mode = toBase;
        }

        private List<string> ParceArgs()
        {
            var output = new List<string>();

            string buffer = String.Empty;
            foreach (char bit in output_field.Text)
            {
                if (!Char.IsDigit(bit))
                {
                    
                }
            }

            return output;
        }

        public Form1()
        {
            InitializeComponent();

            OnModeChange += (BaseMode mode) =>
            {
                base_label.Text = $"Current base: {((int)mode).ToString()}";
                CheckIsValid();
            };
        }

        //////////////////////////////////////////////////////////////////

        private void one_btn_Click(object sender, EventArgs e)
        {
            output_field.Text += '1';
        }

        private void zero_btn_Click_1(object sender, EventArgs e)
        {
            output_field.Text += '0';
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            output_field.Text = String.Empty;
            Mode = BaseMode.BASE2;
        }

        private void to2_btn_Click(object sender, EventArgs e) => ChangeBase(output_field.Text, BaseMode.BASE2);
        private void to10_btn_Click(object sender, EventArgs e) => ChangeBase(output_field.Text, BaseMode.BASE10);
        private void to8_btn_Click(object sender, EventArgs e) => ChangeBase(output_field.Text, BaseMode.BASE8);

        private void to16_btn_Click(object sender, EventArgs e) => ChangeBase(output_field.Text, BaseMode.BASE16);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void change_base_btn_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void output_field_TextChanged(object sender, EventArgs e)
        {
            char[] validChars = { '&', '^', '|', '-' };
            string valid = String.Empty;
            foreach (char bit in output_field.Text)
            {
                if (Char.IsDigit(bit) || Array.IndexOf(validChars, bit) > -1)
                {
                    valid += bit;
                }
            }
            output_field.Text = valid;


            CheckIsValid();
        }

        private void and_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(Convert.ToInt32(output_field.Text, (int)Mode).ToString(), 10);
                output_field.Text = (num & 1).ToString();
                Mode = BaseMode.BASE2;
            }
            catch
            {

            }
        }

        private void or_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string num = Convert.ToString(Convert.ToInt32(output_field.Text, (int)Mode), 2);
                Mode = BaseMode.BASE2;
                foreach (char bit in num)
                {
                    if (bit == '1')
                    {
                        output_field.Text = "1";
                        return;
                    }
                }
                output_field.Text = "0";
            }
            catch
            {

            }
        }

        private void xor_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string num = Convert.ToString(Convert.ToInt32(output_field.Text, (int)Mode), 2);
                Mode = BaseMode.BASE2;
                bool metBit = false;
                
                foreach (char bit in num)
                {
                    if (bit == '1')
                    {
                        if (metBit)
                        {
                            output_field.Text = "0";
                            return;
                        }
                        metBit = true;
                        output_field.Text = "1";
                    }
                }
                if (!metBit)
                    output_field.Text = "0";
            }
            catch
            {

            }
        }

        private void not_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string num = Convert.ToString(Convert.ToInt32(output_field.Text, (int)Mode), 2);
                string output = String.Empty;
                Mode = BaseMode.BASE2;

                foreach (char bit in num)
                {
                    output += (bit == '1') ? '0' : '1';
                }

                output_field.Text = output;
            }
            catch
            {

            }
        }
    }
}
