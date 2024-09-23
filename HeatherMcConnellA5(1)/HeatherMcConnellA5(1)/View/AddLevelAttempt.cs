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
    /// <summary>
    /// AddLevelAttempt Class.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddLevelAttempt : Form
    {
        /// <summary>
        /// My attempt to add
        /// </summary>
        public Attempt myAttemptToAdd;
        public AddLevelAttempt()
        {
            InitializeComponent();
            DateBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }


        /// <summary>
        /// Handles the Click event of the CancelLevelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelLevelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the AddLevelAttemptBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddLevelAttemptBtn_Click(object sender, EventArgs e)
        {
            myAttemptToAdd = new Attempt();

            ErrorMessageBox.Text = string.Empty;
            ErrorMessageBox.Visible = false;

            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string scoreText = ScoreBox.Text.Trim();
            string timeText = TimeBox.Text.Trim();

            int score;


            if (string.IsNullOrEmpty(firstName))
            {
                ErrorMessageBox.Text = "First name cannot be empty.";
                ErrorMessageBox.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                ErrorMessageBox.Text = "Last name cannot be empty.";
                ErrorMessageBox.Visible = true;
                return;
            }

            if (!int.TryParse(scoreText, out score) || score < 0 || score > 100)
            {
                ErrorMessageBox.Text = "Score must be a valid number between 0 and 100.";
                ErrorMessageBox.Visible = true;
                return;
            }

            if (!decimal.TryParse(timeText, out decimal time) || time < 0 || time > 120)
            {
                ErrorMessageBox.Text = "Time must be a valid number between 0.0 and 120";
                ErrorMessageBox.Visible = true;
                return;
            }

            myAttemptToAdd.FirstName = firstName;
            myAttemptToAdd.LastName = lastName;
            myAttemptToAdd.Score = score;
            myAttemptToAdd.Time = time;
            myAttemptToAdd.RunDate = DateTime.Now;

            Close();
        }

        /// <summary>
        /// Handles the Click event of the ErrorMessageBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ErrorMessageBox_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the TextChanged event of the DateBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
