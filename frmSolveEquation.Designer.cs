namespace SimpleCalculator
{
    partial class frmSolveEquation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolveEquation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPasteClipboard = new System.Windows.Forms.Button();
            this.gbNumbers = new System.Windows.Forms.GroupBox();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnChangeSign = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.SolutionScreen = new System.Windows.Forms.TextBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.LinearCoeffcient = new System.Windows.Forms.TextBox();
            this.ConstantTerm = new System.Windows.Forms.TextBox();
            this.LeadingCoefficient = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnPasteClipboard);
            this.groupBox1.Controls.Add(this.gbNumbers);
            this.groupBox1.Controls.Add(this.SolutionScreen);
            this.groupBox1.Controls.Add(this.rbB);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbA);
            this.groupBox1.Controls.Add(this.LinearCoeffcient);
            this.groupBox1.Controls.Add(this.ConstantTerm);
            this.groupBox1.Controls.Add(this.LeadingCoefficient);
            this.groupBox1.Location = new System.Drawing.Point(88, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.IndianRed;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(21, 220);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(78, 28);
            this.btnCopy.TabIndex = 42;
            this.btnCopy.Tag = "";
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPasteClipboard
            // 
            this.btnPasteClipboard.BackColor = System.Drawing.Color.IndianRed;
            this.btnPasteClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteClipboard.Location = new System.Drawing.Point(186, 220);
            this.btnPasteClipboard.Name = "btnPasteClipboard";
            this.btnPasteClipboard.Size = new System.Drawing.Size(78, 28);
            this.btnPasteClipboard.TabIndex = 41;
            this.btnPasteClipboard.Tag = "";
            this.btnPasteClipboard.Text = "Paste";
            this.btnPasteClipboard.UseVisualStyleBackColor = false;
            this.btnPasteClipboard.Click += new System.EventHandler(this.btnPasteClipboard_Click);
            // 
            // gbNumbers
            // 
            this.gbNumbers.BackColor = System.Drawing.Color.Transparent;
            this.gbNumbers.Controls.Add(this.btnNumber5);
            this.gbNumbers.Controls.Add(this.btnClearScreen);
            this.gbNumbers.Controls.Add(this.btnDelete);
            this.gbNumbers.Controls.Add(this.btnNumber1);
            this.gbNumbers.Controls.Add(this.btnChangeSign);
            this.gbNumbers.Controls.Add(this.btnNumber9);
            this.gbNumbers.Controls.Add(this.btnSolve);
            this.gbNumbers.Controls.Add(this.btnNumber8);
            this.gbNumbers.Controls.Add(this.btnNumber2);
            this.gbNumbers.Controls.Add(this.btnNumber4);
            this.gbNumbers.Controls.Add(this.btnDecimalPoint);
            this.gbNumbers.Controls.Add(this.btnNumber7);
            this.gbNumbers.Controls.Add(this.btnNumber3);
            this.gbNumbers.Controls.Add(this.btnNumber6);
            this.gbNumbers.Controls.Add(this.btnNumber0);
            this.gbNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbNumbers.Location = new System.Drawing.Point(0, 240);
            this.gbNumbers.Name = "gbNumbers";
            this.gbNumbers.Size = new System.Drawing.Size(270, 200);
            this.gbNumbers.TabIndex = 2;
            this.gbNumbers.TabStop = false;
            // 
            // btnNumber5
            // 
            this.btnNumber5.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber5.Location = new System.Drawing.Point(78, 55);
            this.btnNumber5.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(46, 41);
            this.btnNumber5.TabIndex = 24;
            this.btnNumber5.Tag = "5";
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = false;
            this.btnNumber5.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScreen.Location = new System.Drawing.Point(186, 57);
            this.btnClearScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(78, 41);
            this.btnClearScreen.TabIndex = 23;
            this.btnClearScreen.Text = "AC";
            this.btnClearScreen.UseVisualStyleBackColor = false;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(186, 103);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 41);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber1.Location = new System.Drawing.Point(21, 101);
            this.btnNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(46, 41);
            this.btnNumber1.TabIndex = 20;
            this.btnNumber1.Tag = "1";
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = false;
            this.btnNumber1.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnChangeSign
            // 
            this.btnChangeSign.BackColor = System.Drawing.Color.IndianRed;
            this.btnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Bold);
            this.btnChangeSign.Location = new System.Drawing.Point(186, 11);
            this.btnChangeSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeSign.Name = "btnChangeSign";
            this.btnChangeSign.Size = new System.Drawing.Size(78, 41);
            this.btnChangeSign.TabIndex = 39;
            this.btnChangeSign.Tag = "negative";
            this.btnChangeSign.Text = "To Negative";
            this.btnChangeSign.UseVisualStyleBackColor = false;
            this.btnChangeSign.Click += new System.EventHandler(this.btnChangeSign_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber9.Location = new System.Drawing.Point(134, 9);
            this.btnNumber9.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(46, 41);
            this.btnNumber9.TabIndex = 26;
            this.btnNumber9.Tag = "9";
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = false;
            this.btnNumber9.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.IndianRed;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(186, 149);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(78, 41);
            this.btnSolve.TabIndex = 31;
            this.btnSolve.Tag = "0";
            this.btnSolve.Text = "solve";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber8.Location = new System.Drawing.Point(78, 9);
            this.btnNumber8.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(46, 41);
            this.btnNumber8.TabIndex = 27;
            this.btnNumber8.Tag = "8";
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = false;
            this.btnNumber8.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnNumber2
            // 
            this.btnNumber2.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber2.Location = new System.Drawing.Point(78, 101);
            this.btnNumber2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(46, 41);
            this.btnNumber2.TabIndex = 21;
            this.btnNumber2.Tag = "2";
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = false;
            this.btnNumber2.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnNumber4
            // 
            this.btnNumber4.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber4.Location = new System.Drawing.Point(21, 55);
            this.btnNumber4.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(46, 41);
            this.btnNumber4.TabIndex = 25;
            this.btnNumber4.Tag = "4";
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = false;
            this.btnNumber4.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnDecimalPoint.Location = new System.Drawing.Point(134, 148);
            this.btnDecimalPoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(46, 41);
            this.btnDecimalPoint.TabIndex = 30;
            this.btnDecimalPoint.Tag = "1";
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = false;
            this.btnDecimalPoint.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnNumber7
            // 
            this.btnNumber7.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber7.Location = new System.Drawing.Point(21, 9);
            this.btnNumber7.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(46, 41);
            this.btnNumber7.TabIndex = 28;
            this.btnNumber7.Tag = "7";
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = false;
            this.btnNumber7.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnNumber3
            // 
            this.btnNumber3.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber3.Location = new System.Drawing.Point(134, 101);
            this.btnNumber3.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(46, 41);
            this.btnNumber3.TabIndex = 22;
            this.btnNumber3.Tag = "3";
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = false;
            this.btnNumber3.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnNumber6
            // 
            this.btnNumber6.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNumber6.Location = new System.Drawing.Point(134, 55);
            this.btnNumber6.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(46, 41);
            this.btnNumber6.TabIndex = 23;
            this.btnNumber6.Tag = "6";
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = false;
            this.btnNumber6.Click += new System.EventHandler(this.Click_Button);
            // 
            // btnNumber0
            // 
            this.btnNumber0.BackColor = System.Drawing.Color.BlueViolet;
            this.btnNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber0.Location = new System.Drawing.Point(21, 147);
            this.btnNumber0.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(102, 41);
            this.btnNumber0.TabIndex = 29;
            this.btnNumber0.Tag = "0";
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = false;
            this.btnNumber0.Click += new System.EventHandler(this.Click_Button);
            // 
            // SolutionScreen
            // 
            this.SolutionScreen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SolutionScreen.Location = new System.Drawing.Point(35, 28);
            this.SolutionScreen.Multiline = true;
            this.SolutionScreen.Name = "SolutionScreen";
            this.SolutionScreen.Size = new System.Drawing.Size(194, 80);
            this.SolutionScreen.TabIndex = 37;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(18, 154);
            this.rbB.Margin = new System.Windows.Forms.Padding(2);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(14, 13);
            this.rbB.TabIndex = 36;
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(18, 178);
            this.rbC.Margin = new System.Windows.Forms.Padding(2);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(14, 13);
            this.rbC.TabIndex = 35;
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.Location = new System.Drawing.Point(18, 130);
            this.rbA.Margin = new System.Windows.Forms.Padding(2);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(14, 13);
            this.rbA.TabIndex = 34;
            this.rbA.TabStop = true;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // LinearCoeffcient
            // 
            this.LinearCoeffcient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearCoeffcient.Location = new System.Drawing.Point(35, 151);
            this.LinearCoeffcient.Margin = new System.Windows.Forms.Padding(2);
            this.LinearCoeffcient.Name = "LinearCoeffcient";
            this.LinearCoeffcient.ReadOnly = true;
            this.LinearCoeffcient.Size = new System.Drawing.Size(194, 24);
            this.LinearCoeffcient.TabIndex = 33;
            this.LinearCoeffcient.Text = "b = ";
            // 
            // ConstantTerm
            // 
            this.ConstantTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstantTerm.Location = new System.Drawing.Point(35, 178);
            this.ConstantTerm.Margin = new System.Windows.Forms.Padding(2);
            this.ConstantTerm.Name = "ConstantTerm";
            this.ConstantTerm.ReadOnly = true;
            this.ConstantTerm.Size = new System.Drawing.Size(194, 24);
            this.ConstantTerm.TabIndex = 32;
            this.ConstantTerm.Text = "c = ";
            // 
            // LeadingCoefficient
            // 
            this.LeadingCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeadingCoefficient.Location = new System.Drawing.Point(35, 123);
            this.LeadingCoefficient.Margin = new System.Windows.Forms.Padding(2);
            this.LeadingCoefficient.Name = "LeadingCoefficient";
            this.LeadingCoefficient.ReadOnly = true;
            this.LeadingCoefficient.Size = new System.Drawing.Size(194, 24);
            this.LeadingCoefficient.TabIndex = 0;
            this.LeadingCoefficient.Text = "a = ";
            // 
            // frmSolveEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 499);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSolveEquation";
            this.Text = "frmSolveEquation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbNumbers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox LinearCoeffcient;
        private System.Windows.Forms.TextBox ConstantTerm;
        private System.Windows.Forms.TextBox LeadingCoefficient;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.TextBox SolutionScreen;
        private System.Windows.Forms.Button btnChangeSign;
        private System.Windows.Forms.GroupBox gbNumbers;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPasteClipboard;
    }
}