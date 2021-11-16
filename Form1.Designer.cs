
namespace _3x_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumbersBox = new System.Windows.Forms.ListBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.NumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumbersLabel = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumbersBox
            // 
            this.NumbersBox.FormattingEnabled = true;
            this.NumbersBox.ItemHeight = 15;
            this.NumbersBox.Location = new System.Drawing.Point(13, 13);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(676, 424);
            this.NumbersBox.TabIndex = 0;
            this.NumbersBox.TabStop = false;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(694, 71);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(93, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // NumberUpDown
            // 
            this.NumberUpDown.Location = new System.Drawing.Point(695, 13);
            this.NumberUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumberUpDown.Name = "NumberUpDown";
            this.NumberUpDown.Size = new System.Drawing.Size(92, 23);
            this.NumberUpDown.TabIndex = 0;
            this.NumberUpDown.ValueChanged += new System.EventHandler(this.NumberUpDown_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(693, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IntervalUpDown
            // 
            this.IntervalUpDown.Location = new System.Drawing.Point(694, 42);
            this.IntervalUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IntervalUpDown.Name = "IntervalUpDown";
            this.IntervalUpDown.Size = new System.Drawing.Size(92, 23);
            this.IntervalUpDown.TabIndex = 1;
            this.IntervalUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IntervalUpDown.ValueChanged += new System.EventHandler(this.IntervalUpDown_ValueChanged);
            // 
            // NumbersLabel
            // 
            this.NumbersLabel.AutoSize = true;
            this.NumbersLabel.Location = new System.Drawing.Point(696, 130);
            this.NumbersLabel.Name = "NumbersLabel";
            this.NumbersLabel.Size = new System.Drawing.Size(13, 15);
            this.NumbersLabel.TabIndex = 4;
            this.NumbersLabel.Text = "0";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(696, 413);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(92, 23);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.NumbersLabel);
            this.Controls.Add(this.IntervalUpDown);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NumberUpDown);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.NumbersBox);
            this.Name = "Form1";
            this.Text = "3x + 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NumbersBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.NumericUpDown NumberUpDown;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown IntervalUpDown;
        private System.Windows.Forms.Label NumbersLabel;
        private System.Windows.Forms.Button ExportButton;
    }
}

