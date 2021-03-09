﻿using System;
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

    public partial class Form1 : Form
    {

        private delegate void ModeChange(BaseMode mode);
        private event ModeChange OnModeChange;

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

        private void ChangeBase(string number, BaseMode toBase)
        {
            if (String.IsNullOrEmpty(number) || mode == toBase)
                return;
            output_field.Text = Convert.ToString(Convert.ToInt32(number, (int)Mode), (int)toBase);
            Mode = toBase;
        }

        public Form1()
        {
            InitializeComponent();

            OnModeChange += (BaseMode mode) =>
            {
                base_label.Text = $"Current base: {((int)mode).ToString()}";
            };
        }

        //////////////////////////////////////////////////////////////////

        private void output_field_TextChanged(object sender, EventArgs e)
        {
            
        }

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
    }
}