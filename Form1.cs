using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _3x_1
{
    public partial class Form1 : Form
    {

        private int num;
        private int interval;
        private int iterations;
        private int initial;
        private bool calculate = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();

            new ToolTip().SetToolTip(NumberUpDown, "The number you want to use for calculations.");
            new ToolTip().SetToolTip(IntervalUpDown, "Time time in ms to wait before the next calculation.");
        }

        private void NumberUpDown_ValueChanged(object sender, EventArgs e)
        {
            GoButton.Enabled = NumberUpDown.Value > 0;
        }

        private void IntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            interval = (int)IntervalUpDown.Value;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            GoButton.Enabled = false;
            CancelButton.Enabled = true;
            calculate = true;

            num = (int)NumberUpDown.Value;
            initial = num;
            iterations = 0;

            NumbersLabel.Text = iterations.ToString();
            NumbersBox.Items.Clear();

            Calculate();
        }

        private void Calculate()
        {
            if (!calculate)
                return;

            num = Math.Abs(num);

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

            num = Math.Abs(num);

            iterations++;
            NumbersBox.Items.Add(num.ToString());
            NumbersBox.SelectedIndex = NumbersBox.Items.Count - 1;
            NumbersLabel.Text = iterations.ToString();

            if (num != (int)NumberUpDown.Value && num != 1)
            {
                Wait(interval);
                Calculate();
                return;
            }

            calculate = false;
            NumberUpDown.Enabled = true;
            GoButton.Enabled = true;
            ExportButton.Enabled = true;

            MessageBox.Show("Finished!", "3x + 1");
        }

        private void Reset()
        {
            calculate = false;
            NumberUpDown.Enabled = true;
            GoButton.Enabled = false;
            ExportButton.Enabled = false;
            CancelButton.Enabled = false;

            iterations = 0;

            NumbersLabel.Text = iterations.ToString();
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

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("./Exports"))
                Directory.CreateDirectory("./Exports");

            List<string> numbers = new List<string>();
            for (int i = 0; i < NumbersBox.Items.Count; i++)
            {
                numbers.Add(NumbersBox.Items[i].ToString());
            }

            try
            {
                File.WriteAllLines($"./Exports/{initial}.txt", numbers.ToArray());
                MessageBox.Show($"Calculations exported as \"{initial}.txt\" to \"./Exports\" successfully.", "3x + 1");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
