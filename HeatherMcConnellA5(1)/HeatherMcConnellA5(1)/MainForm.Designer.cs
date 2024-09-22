namespace HeatherMcConnellA5_1_
{
    partial class MainForm
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
            LevelAttemptsLbl = new Label();
            LevelAttemptsListBox = new ListBox();
            AddAttemptBtn = new Button();
            RemoveAttemptBtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // LevelAttemptsLbl
            // 
            LevelAttemptsLbl.AutoSize = true;
            LevelAttemptsLbl.Location = new Point(44, 49);
            LevelAttemptsLbl.Name = "LevelAttemptsLbl";
            LevelAttemptsLbl.Size = new Size(134, 25);
            LevelAttemptsLbl.TabIndex = 0;
            LevelAttemptsLbl.Text = "Level Attempts:";
            // 
            // LevelAttemptsListBox
            // 
            LevelAttemptsListBox.FormattingEnabled = true;
            LevelAttemptsListBox.ItemHeight = 25;
            LevelAttemptsListBox.Location = new Point(44, 99);
            LevelAttemptsListBox.Name = "LevelAttemptsListBox";
            LevelAttemptsListBox.Size = new Size(306, 254);
            LevelAttemptsListBox.TabIndex = 1;
            // 
            // AddAttemptBtn
            // 
            AddAttemptBtn.Location = new Point(97, 371);
            AddAttemptBtn.Name = "AddAttemptBtn";
            AddAttemptBtn.Size = new Size(169, 34);
            AddAttemptBtn.TabIndex = 2;
            AddAttemptBtn.Text = "Add Attempt";
            AddAttemptBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveAttemptBtn
            // 
            RemoveAttemptBtn.Location = new Point(97, 427);
            RemoveAttemptBtn.Name = "RemoveAttemptBtn";
            RemoveAttemptBtn.Size = new Size(163, 34);
            RemoveAttemptBtn.TabIndex = 3;
            RemoveAttemptBtn.Text = "Remove Attempt";
            RemoveAttemptBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 50);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 4;
            label1.Text = "Level Attempt Stats:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(472, 104);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 540);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(RemoveAttemptBtn);
            Controls.Add(AddAttemptBtn);
            Controls.Add(LevelAttemptsListBox);
            Controls.Add(LevelAttemptsLbl);
            Name = "MainForm";
            Text = "Heather McConnell A5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LevelAttemptsLbl;
        private ListBox LevelAttemptsListBox;
        private Button AddAttemptBtn;
        private Button RemoveAttemptBtn;
        private Label label1;
        private TextBox textBox1;
    }
}
