using HeatherMcConnellA5_1_.Model;
using HeatherMcConnellA5_1_.View;

namespace HeatherMcConnellA5_1_
{
    public partial class MainForm : Form
    {
        private AddLevelAttempt addLevelAttempt;

        private List<Attempt> MyAttempts;
        public MainForm()
        {
            InitializeComponent();
            MyAttempts = new List<Attempt>();
        }

        private void AddAttemptBtn_Click(object sender, EventArgs e)
        {
            addLevelAttempt = new AddLevelAttempt();
            addLevelAttempt.ShowDialog();

            MyAttempts.Add(addLevelAttempt.myAttemptToAdd);

            LevelAttemptsListBox.DataSource = null;
            LevelAttemptsListBox.Items.Clear();
            LevelAttemptsListBox.DataSource = MyAttempts;
        }

        private void RemoveAttemptBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = (Attempt)LevelAttemptsListBox.SelectedItem;

            MyAttempts.Remove(selectedItem);
            LevelAttemptsListBox.DataSource = null;
            LevelAttemptsListBox.Items.Clear();
            LevelAttemptsListBox.DataSource = null;

        }
    }
}
