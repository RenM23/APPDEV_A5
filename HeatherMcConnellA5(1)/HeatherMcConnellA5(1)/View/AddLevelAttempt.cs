using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeatherMcConnellA5_1_.Model;

namespace HeatherMcConnellA5_1_.View
{
    public partial class AddLevelAttempt : Form
    {
        public Attempt myAttemptToAdd;
        public AddLevelAttempt()
        {
            InitializeComponent();
        }

        private void CancelLevelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddLevelAttemptBtn_Click(object sender, EventArgs e)
        {
            myAttemptToAdd = new Attempt();

            myAttemptToAdd.FirstName = FirstNameTextBox.Text;
            myAttemptToAdd.LastName = LastNameTextBox.Text;
            myAttemptToAdd.Score = int.Parse(ScoreBox.Text);
            myAttemptToAdd.Time = int.Parse(TimeBox.Text);
            myAttemptToAdd.RunDate = DateTime.Now;


           Close();
        }
    }
}
