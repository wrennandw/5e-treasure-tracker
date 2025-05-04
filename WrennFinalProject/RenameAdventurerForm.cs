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
    public partial class RenameAdventurerForm : Form
    {
        // Build the form and receive a reference to the main form
        private MainForm mainFormRef;
        private int tabIndex;
        public RenameAdventurerForm(MainForm mainForm, int index)
        {
            InitializeComponent();
            mainFormRef = mainForm;
            tabIndex = mainFormRef.treasureListTabControl.SelectedIndex;
            this.adventurerNameTextbox.Text = 
                Controller.adventurerTabs[tabIndex].adventurerName;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            // Only trigger a rename if the string isn't empty
            if (this.adventurerNameTextbox.Text != "")
            {
                Controller.adventurerTabs[tabIndex].adventurerName =
                    this.adventurerNameTextbox.Text;
                mainFormRef.treasureListTabControl.SelectedTab.Text =
                    this.adventurerNameTextbox.Text;
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
