using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrennFinalProject
{
    public partial class AddAdventurerForm : Form
    {
        // Build the form and receive a reference to the main form
        private MainForm mainFormRef;
        public AddAdventurerForm(MainForm mainForm)
        {
            InitializeComponent();
            mainFormRef = mainForm;
            
            // Initialize class dropdown
            classSelectDropdown.SelectedIndex = 0;
        }

        private void createAdventurerButton_Click(object sender, EventArgs e)
        {
            mainFormRef.treasureListTabControl.TabPages.Add(adventurerNameTextbox.Text);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
