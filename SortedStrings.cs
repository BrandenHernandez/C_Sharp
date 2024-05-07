/* Sorted Strings (SortedStrings.cs)
 * VeryAble TMCC 3-3-2018
 * Write an app that allows the user to enter strings in a TextBox.
 * Each string input is added to a ListBox.
 * As each string is added to the ListBox, ensure that the strings are in sorted order. [Note: use property Sorted.]
 */using System;
using System.Windows.Forms;

namespace SortingStrings.cs
{
    public partial class SortedStringsForm : Form
    {
        // Default constructor
        public SortedStringsForm()
        {
            InitializeComponent();
        }

        // If enter is pressed, add word to list
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // If enter is pressed
            {
                //enter key is down
                lbDisplay.Items.Add(tbInput.Text); // Add word in textbox to list
                lbDisplay.Sorted = true; // Sort in alphabetical order
                tbInput.Clear(); // Clear textbox
            }
        }

        //if an item is selected, remove item from list
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check whether item is selected
            // If so, remove
            if (lbDisplay.SelectedIndex != -1)
            {
                lbDisplay.Items.RemoveAt(lbDisplay.SelectedIndex);
            }
        }

        // Clear all items in ListBox
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear(); // Clear all
        }

        // Exite application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit
        }
    }
// Thanks for looking
}
