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
        int tabIndex;

        public AddAdventurerForm(MainForm mainForm, int index)
        {
            InitializeComponent();
            mainFormRef = mainForm;
            tabIndex = index;
            // Initialize class dropdown
            classSelectDropdown.SelectedIndex = 0;
        }

        private void createAdventurerButton_Click(object sender, EventArgs e)
        {
            if (adventurerNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter a name for this character!");
            }
            else
            {
                string portraitPath = "..\\images\\";
                portraitPath += classSelectDropdown.Text;
                portraitPath += ".png";
                Adventurer adventurer = new Adventurer(mainFormRef,
                    adventurerNameTextbox.Text, portraitPath);
                Controller.addAdventurer(adventurer, tabIndex, mainFormRef);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
