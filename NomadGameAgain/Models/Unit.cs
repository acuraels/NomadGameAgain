using System.Windows.Forms;

namespace NomadGameAgain.GameObjects
{
    public class Unit : UserControl
    {
        public void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Unit
            // 
            this.Name = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            this.ResumeLayout(false);

        }

        private void Unit_Load(object sender, System.EventArgs e)
        {

        }
    }
}
