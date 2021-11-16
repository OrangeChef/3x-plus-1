
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
            this.StartButton = new System.Windows.Forms.Button();
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
            this.NumbersBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbersBox.FormattingEnabled = true;
            this.NumbersBox.ItemHeight = 15;
            this.NumbersBox.Location = new System.Drawing.Point(13, 13);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(460, 439);
            this.NumbersBox.TabIndex = 0;
            this.NumbersBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(478, 71);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(93, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // NumberUpDown
            // 
            this.NumberUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberUpDown.Location = new System.Drawing.Point(479, 13);
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
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(478, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IntervalUpDown
            // 
            this.IntervalUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalUpDown.Location = new System.Drawing.Point(478, 42);
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
            this.NumbersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbersLabel.AutoSize = true;
            this.NumbersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumbersLabel.Location = new System.Drawing.Point(479, 126);
            this.NumbersLabel.Name = "NumbersLabel";
            this.NumbersLabel.Size = new System.Drawing.Size(84, 15);
            this.NumbersLabel.TabIndex = 4;
            this.NumbersLabel.Text = "Calculations: 0";
            this.NumbersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(480, 426);
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
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.NumbersLabel);
            this.Controls.Add(this.IntervalUpDown);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NumberUpDown);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NumbersBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3x + 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NumbersBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown NumberUpDown;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown IntervalUpDown;
        private System.Windows.Forms.Label NumbersLabel;
        private System.Windows.Forms.Button ExportButton;
    }
}

