using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _3x_1
{
    public partial class Form1 : Form
    {

        private int num;
        private bool calculate = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void NumberUpDown_ValueChanged(object sender, EventArgs e)
        {
            GoButton.Enabled = NumberUpDown.Value > 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            GoButton.Enabled = false;
            num = (int)NumberUpDown.Value;
            calculate = true;

            NumbersBox.Items.Clear();

            Calculate();
        }

        private void Calculate()
        {
            if (!calculate)
                return;

            bool even = num % 2 == 0;

            if (even)
            {
                num /= 2;
            }
            else
            {
                num *= 3;
                num++;
            }

            NumbersBox.Items.Add(num.ToString());
            NumbersBox.SelectedIndex = NumbersBox.Items.Count - 1;

            if (num != (int)NumberUpDown.Value && num != 1)
            {
                Wait(10);
                Calculate();
                return;
            }

            calculate = false;
            NumberUpDown.Enabled = true;
            GoButton.Enabled = true;

            MessageBox.Show("Finished!", "3x + 1");
        }

        private void Reset()
        {
            calculate = false;
            NumberUpDown.Enabled = true;
            GoButton.Enabled = false;
        }

        private void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
