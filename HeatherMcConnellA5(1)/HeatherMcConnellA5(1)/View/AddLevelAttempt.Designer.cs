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
            ScoreBox = new NumericUpDown();
            AttemptTimeLbl = new Label();
            TimeBox = new TextBox();
            label1 = new Label();
            DateBox = new TextBox();
            AddLevelAttemptBtn = new Button();
            CancelLevelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ScoreBox).BeginInit();
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
            // ScoreBox
            // 
            ScoreBox.Location = new Point(235, 213);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.ReadOnly = true;
            ScoreBox.Size = new Size(150, 31);
            ScoreBox.TabIndex = 5;
            ScoreBox.TextAlign = HorizontalAlignment.Center;
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
            // TimeBox
            // 
            TimeBox.Location = new Point(235, 267);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(150, 31);
            TimeBox.TabIndex = 7;
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
            // DateBox
            // 
            DateBox.Location = new Point(235, 322);
            DateBox.Name = "DateBox";
            DateBox.ReadOnly = true;
            DateBox.Size = new Size(150, 31);
            DateBox.TabIndex = 9;
            // 
            // AddLevelAttemptBtn
            // 
            AddLevelAttemptBtn.Location = new Point(105, 384);
            AddLevelAttemptBtn.Name = "AddLevelAttemptBtn";
            AddLevelAttemptBtn.Size = new Size(112, 34);
            AddLevelAttemptBtn.TabIndex = 10;
            AddLevelAttemptBtn.Text = "Add";
            AddLevelAttemptBtn.UseVisualStyleBackColor = true;
            AddLevelAttemptBtn.Click += AddLevelAttemptBtn_Click;
            // 
            // CancelLevelBtn
            // 
            CancelLevelBtn.Location = new Point(268, 387);
            CancelLevelBtn.Name = "CancelLevelBtn";
            CancelLevelBtn.Size = new Size(112, 34);
            CancelLevelBtn.TabIndex = 11;
            CancelLevelBtn.Text = "Cancel";
            CancelLevelBtn.UseVisualStyleBackColor = true;
            CancelLevelBtn.Click += CancelLevelBtn_Click;
            // 
            // AddLevelAttempt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 543);
            Controls.Add(CancelLevelBtn);
            Controls.Add(AddLevelAttemptBtn);
            Controls.Add(DateBox);
            Controls.Add(label1);
            Controls.Add(TimeBox);
            Controls.Add(AttemptTimeLbl);
            Controls.Add(ScoreBox);
            Controls.Add(ScoreLbl);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLbl);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLbl);
            Name = "AddLevelAttempt";
            Text = "AddLevelAttempt";
            ((System.ComponentModel.ISupportInitialize)ScoreBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLbl;
        private TextBox FirstNameTextBox;
        private Label LastNameLbl;
        private TextBox LastNameTextBox;
        private Label ScoreLbl;
        private NumericUpDown ScoreBox;
        private Label AttemptTimeLbl;
        private TextBox TimeBox;
        private Label label1;
        private TextBox DateBox;
        private Button AddLevelAttemptBtn;
        private Button CancelLevelBtn;
    }
}