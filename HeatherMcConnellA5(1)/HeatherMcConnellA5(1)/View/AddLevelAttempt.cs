using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatherMcConnellA5_1_.View
{
    public partial class AddLevelAttempt : Form
    {
        public AddLevelAttempt()
        {
            InitializeComponent();
        }

        private void CancelLevelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
