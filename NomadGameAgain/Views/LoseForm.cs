using System;
using System.Windows.Forms;

namespace NomadGameAgain.Views
{
    public partial class LoseForm : Form
    {
        public LoseForm()
        {
            InitializeComponent();
        }

        private void LoseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
