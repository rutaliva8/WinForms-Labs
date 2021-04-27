using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.inst.Font = searchType.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Settings.inst.TextSize = (float)numericUpDown1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.inst.TextColor = textBox1.Text;
        }
    }
}
