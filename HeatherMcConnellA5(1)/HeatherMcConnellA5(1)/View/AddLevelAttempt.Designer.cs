namespace HeatherMcConnellA5_1_.View
{
    partial class AddLevelAttempt
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
            FirstNameLbl = new Label();
            FirstNameTextBox = new TextBox();
            LastNameLbl = new Label();
            LastNameTextBox = new TextBox();
            ScoreLbl = new Label();
            numericUpDown1 = new NumericUpDown();
            AttemptTimeLbl = new Label();
            TimeLbl = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            AddLevelAttemptBtn = new Button();
            CancelLevelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.Location = new Point(118, 118);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(101, 25);
            FirstNameLbl.TabIndex = 0;
            FirstNameLbl.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(235, 112);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(150, 31);
            FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameLbl
            // 
            LastNameLbl.AutoSize = true;
            LastNameLbl.Location = new Point(118, 168);
            LastNameLbl.Name = "LastNameLbl";
            LastNameLbl.Size = new Size(99, 25);
            LastNameLbl.TabIndex = 2;
            LastNameLbl.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(235, 162);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(150, 31);
            LastNameTextBox.TabIndex = 3;
            // 
            // ScoreLbl
            // 
            ScoreLbl.AutoSize = true;
            ScoreLbl.Location = new Point(159, 219);
            ScoreLbl.Name = "ScoreLbl";
            ScoreLbl.Size = new Size(60, 25);
            ScoreLbl.TabIndex = 4;
            ScoreLbl.Text = "Score:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(235, 213);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // AttemptTimeLbl
            // 
            AttemptTimeLbl.AutoSize = true;
            AttemptTimeLbl.Location = new Point(94, 267);
            AttemptTimeLbl.Name = "AttemptTimeLbl";
            AttemptTimeLbl.Size = new Size(125, 25);
            AttemptTimeLbl.TabIndex = 6;
            AttemptTimeLbl.Text = "Attempt Time:";
            // 
            // TimeLbl
            // 
            TimeLbl.Location = new Point(235, 267);
            TimeLbl.Name = "TimeLbl";
            TimeLbl.Size = new Size(150, 31);
            TimeLbl.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 322);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 8;
            label1.Text = "Attempt Date:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 322);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 9;
            // 
            // AddLevelAttemptBtn
            // 
            AddLevelAttemptBtn.Location = new Point(105, 384);
            AddLevelAttemptBtn.Name = "AddLevelAttemptBtn";
            AddLevelAttemptBtn.Size = new Size(112, 34);
            AddLevelAttemptBtn.TabIndex = 10;
            AddLevelAttemptBtn.Text = "Add";
            AddLevelAttemptBtn.UseVisualStyleBackColor = true;
            // 
            // CancelLevelBtn
            // 
            CancelLevelBtn.Location = new Point(268, 387);
            CancelLevelBtn.Name = "CancelLevelBtn";
            CancelLevelBtn.Size = new Size(112, 34);
            CancelLevelBtn.TabIndex = 11;
            CancelLevelBtn.Text = "Cancel";
            CancelLevelBtn.UseVisualStyleBackColor = true;
            // 
            // AddLevelAttempt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 543);
            Controls.Add(CancelLevelBtn);
            Controls.Add(AddLevelAttemptBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(TimeLbl);
            Controls.Add(AttemptTimeLbl);
            Controls.Add(numericUpDown1);
            Controls.Add(ScoreLbl);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLbl);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLbl);
            Name = "AddLevelAttempt";
            Text = "AddLevelAttempt";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLbl;
        private TextBox FirstNameTextBox;
        private Label LastNameLbl;
        private TextBox LastNameTextBox;
        private Label ScoreLbl;
        private NumericUpDown numericUpDown1;
        private Label AttemptTimeLbl;
        private TextBox TimeLbl;
        private Label label1;
        private TextBox textBox1;
        private Button AddLevelAttemptBtn;
        private Button CancelLevelBtn;
    }
}