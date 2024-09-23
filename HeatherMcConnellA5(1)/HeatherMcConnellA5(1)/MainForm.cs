using HeatherMcConnellA5_1_.Model;
using HeatherMcConnellA5_1_.View;

namespace HeatherMcConnellA5_1_
{
    /// <summary>
    /// MainForm Form
    /// </summary>
    public partial class MainForm : Form
    {
        private AddLevelAttempt addLevelAttempt;
        private List<Attempt> MyAttempts;
        private LevelAttempts levelAttempts;

        /// <summary>
        /// Main Form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            MyAttempts = new List<Attempt>();
            levelAttempts = new LevelAttempts();
        }

        /// <summary>
        /// Handles Click event for AddAttemptBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAttemptBtn_Click(object sender, EventArgs e)
        {
            addLevelAttempt = new AddLevelAttempt();
            addLevelAttempt.ShowDialog();

            MyAttempts.Add(addLevelAttempt.myAttemptToAdd);
            levelAttempts.AddLevel(addLevelAttempt.myAttemptToAdd);

            LevelAttemptsListBox.DataSource = null;
            LevelAttemptsListBox.Items.Clear();
            LevelAttemptsListBox.DataSource = MyAttempts;

            UpdateStats();
        }

        /// <summary>
        /// Handles the Click Event for RemoveAttemptBtn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAttemptBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = (Attempt)LevelAttemptsListBox.SelectedItem;

            MyAttempts.Remove(selectedItem);
            levelAttempts.RunAttempts.Remove(selectedItem);

            LevelAttemptsListBox.DataSource = null;
            LevelAttemptsListBox.Items.Clear();
            LevelAttemptsListBox.DataSource = MyAttempts;

            UpdateStats();

        }

        /// <summary>
        /// Updates the Stats in the LevelAttemptStatsBox.
        /// </summary>
        private void UpdateStats()
        {
            LevelAttemptStatsBox.Text = levelAttempts.GetStatsSummary();
            
        }

        /// <summary>
        /// Level Attempt Stats Box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LevelAttemptStatsBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
