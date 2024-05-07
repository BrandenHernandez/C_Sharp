using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Click Me!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!tbEntry.Text.Equals(""))
            {
                string message = tbEntry.Text;
               
                if (cbDouble.Checked == true)
                {
                    message += " " + message;
                    lstItems.Items.Add(message);
                }
                else { lstItems.Items.Add(message); }
                tbEntry.Clear();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Let's Begin...");
        }
    }
// Thanks for looking
}
