namespace WindowsFormsApp1
{
    partial class presentValue
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
            this.calcPresentValue = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.introLabel = new System.Windows.Forms.Label();
            this.presentValueText = new System.Windows.Forms.Label();
            this.calculatedPresentValue = new System.Windows.Forms.TextBox();
            this.futureLabel = new System.Windows.Forms.Label();
            this.annualInterestLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.futureValue = new System.Windows.Forms.TextBox();
            this.annualInterestRate = new System.Windows.Forms.TextBox();
            this.yearsFermenting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcPresentValue
            // 
            this.calcPresentValue.Location = new System.Drawing.Point(117, 412);
            this.calcPresentValue.Name = "calcPresentValue";
            this.calcPresentValue.Size = new System.Drawing.Size(247, 89);
            this.calcPresentValue.TabIndex = 0;
            this.calcPresentValue.Text = "Calculate Present Value";
            this.calcPresentValue.UseVisualStyleBackColor = true;
            this.calcPresentValue.Click += new System.EventHandler(this.CalcPresentValue_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Location = new System.Drawing.Point(471, 412);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(244, 86);
            this.exitProgram.TabIndex = 1;
            this.exitProgram.Text = "Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.Location = new System.Drawing.Point(238, 23);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(424, 60);
            this.introLabel.TabIndex = 2;
            this.introLabel.Text = "Caclulate the \"Present Value\" of your investment,\r\nthe amount you should deposit " +
    "today,\r\nby inputting values into the following boxes: ";
            this.introLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presentValueText
            // 
            this.presentValueText.AutoSize = true;
            this.presentValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValueText.Location = new System.Drawing.Point(57, 347);
            this.presentValueText.Name = "presentValueText";
            this.presentValueText.Size = new System.Drawing.Size(394, 24);
            this.presentValueText.TabIndex = 3;
            this.presentValueText.Text = "The Present Value for your investment is:";
            // 
            // calculatedPresentValue
            // 
            this.calculatedPresentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatedPresentValue.Location = new System.Drawing.Point(487, 349);
            this.calculatedPresentValue.Name = "calculatedPresentValue";
            this.calculatedPresentValue.ReadOnly = true;
            this.calculatedPresentValue.Size = new System.Drawing.Size(228, 22);
            this.calculatedPresentValue.TabIndex = 4;
            // 
            // futureLabel
            // 
            this.futureLabel.AutoSize = true;
            this.futureLabel.Location = new System.Drawing.Point(114, 144);
            this.futureLabel.Name = "futureLabel";
            this.futureLabel.Size = new System.Drawing.Size(330, 17);
            this.futureLabel.TabIndex = 5;
            this.futureLabel.Text = "Enter the future value that you want in the account:";
            // 
            // annualInterestLabel
            // 
            this.annualInterestLabel.AutoSize = true;
            this.annualInterestLabel.Location = new System.Drawing.Point(129, 212);
            this.annualInterestLabel.Name = "annualInterestLabel";
            this.annualInterestLabel.Size = new System.Drawing.Size(315, 17);
            this.annualInterestLabel.TabIndex = 6;
            this.annualInterestLabel.Text = "Enter the the annual interest rate of the account:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(129, 264);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(322, 34);
            this.yearsLabel.TabIndex = 7;
            this.yearsLabel.Text = "Enter the fthe number of years that you plan to let\r\nthe money sit in the account" +
    ":";
            // 
            // futureValue
            // 
            this.futureValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.futureValue.Location = new System.Drawing.Point(487, 146);
            this.futureValue.Name = "futureValue";
            this.futureValue.Size = new System.Drawing.Size(228, 22);
            this.futureValue.TabIndex = 8;
            // 
            // annualInterestRate
            // 
            this.annualInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.annualInterestRate.Location = new System.Drawing.Point(487, 207);
            this.annualInterestRate.Name = "annualInterestRate";
            this.annualInterestRate.Size = new System.Drawing.Size(228, 22);
            this.annualInterestRate.TabIndex = 11;
            // 
            // yearsFermenting
            // 
            this.yearsFermenting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearsFermenting.Location = new System.Drawing.Point(487, 276);
            this.yearsFermenting.Name = "yearsFermenting";
            this.yearsFermenting.Size = new System.Drawing.Size(228, 22);
            this.yearsFermenting.TabIndex = 12;
            // 
            // presentValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 541);
            this.Controls.Add(this.yearsFermenting);
            this.Controls.Add(this.annualInterestRate);
            this.Controls.Add(this.futureValue);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.annualInterestLabel);
            this.Controls.Add(this.futureLabel);
            this.Controls.Add(this.calculatedPresentValue);
            this.Controls.Add(this.presentValueText);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.calcPresentValue);
            this.Name = "presentValue";
            this.Text = "Present Value";
            this.Load += new System.EventHandler(this.PresentValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcPresentValue;
        private System.Windows.Forms.Button exitProgram;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label presentValueText;
        private System.Windows.Forms.TextBox calculatedPresentValue;
        private System.Windows.Forms.Label futureLabel;
        private System.Windows.Forms.Label annualInterestLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox futureValue;
        private System.Windows.Forms.TextBox annualInterestRate;
        private System.Windows.Forms.TextBox yearsFermenting;
    }
}

