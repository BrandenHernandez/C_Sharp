using System;
using System.Windows.Forms;

namespace MDI_Form
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// File > New creates a new child to parent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm cf = new ChildForm(); // Child Constructor
            cf.MdiParent = this; // Informs child of parent
            cf.Show(); // Show to the world
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nothingToSeeHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move along.");
        }
    }
// Thanks for looking
}
