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
    public partial class RenamePartyForm : Form
    {
        // Build the form and receive a reference to the main form
        private MainForm mainFormRef;
        public RenamePartyForm(MainForm mainForm)
        {
            InitializeComponent();
            mainFormRef = mainForm;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            // Only trigger a rename if the string isn't empty
            if (this.textBox1.Text != "")   
            {
                // Warn if name is too long
                if (this.textBox1.Text.Length > 45) 
                {
                    MessageBox.Show("Maximum name length is 45 characters!");
                }
                // Send the new name to the updater
                else
                {
                    mainFormRef.updatePartyName(this.textBox1.Text); 
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
