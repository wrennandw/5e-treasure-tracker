/*
Project name: WrennFinalProject
Author : Andrew Wrenn
Date : 4/20/2025
Description : A treasure and inventory tracker for D&D 5th Edition
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrennFinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Update the Party Name field from the rename form
        public void updatePartyName(string name)
        {
            partyNameLabel.Text = name;

            // Adjust the party name font size based on length
            if (name.Length < 24)
            {
                partyNameLabel.Font = new Font("Book Antiqua", 24);
            }
            else if (name.Length < 28)
            {
                partyNameLabel.Font = new Font("Book Antiqua", 20);
            }
            else
            {
                partyNameLabel.Font = new Font("Book Antiqua", 16);
            }

        }

        // Add an item from the AddItem form
        public void addItem(ListViewItem item)
        {
            allListView.Items.Add(item);
        }

        // Edit an existing item from the EditItem form
        public void editItem(ListViewItem item, int index)
        {
            allListView.Items[index] = item;
        }

        // Click handlers
        private void partyNameLabel_Click(object sender, EventArgs e)
        {
            RenamePartyForm partyNameForm = new RenamePartyForm(this); 
            partyNameForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateTreasureButton_Click(object sender, EventArgs e)
        {
            GenerateTreasureForm genTreasureForm = new GenerateTreasureForm(this);
            genTreasureForm.ShowDialog();
        }

        private void generateHoardButton_Click(object sender, EventArgs e)
        {
            GenerateHoardForm genHoardForm = new GenerateHoardForm(this);
            genHoardForm.ShowDialog();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(this);
            addItemForm.ShowDialog();
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            allListView.Items.Clear();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                allListView.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("No item is selected!");
            }
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditItemForm editItemForm = new EditItemForm(this,
                    allListView.SelectedItems[0]);
                editItemForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No item is selected!");
            }
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            // Get the current path and set up the save folder
            string currentPath = Environment.CurrentDirectory;
            currentPath += "\\savedata";
            saveFileDialog.InitialDirectory = currentPath;
            
            // Create the save directory if it doesn't already exist
            if (!Directory.Exists(currentPath)){
                Directory.CreateDirectory(currentPath);
            }
            
            // For some reason setting the default path only works
            // with this disabled
            saveFileDialog.AutoUpgradeEnabled = false;

            // Initialize the StreamWriter object
            StreamWriter outputFile;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);
                // Write each item to a line in the save file
                // Might change this to JSON encoding later
                for (int i = 0; i < allListView.Items.Count; i++)
                {
                    string line = allListView.Items[i].Text;
                    line += "|";
                    line += allListView.Items[i].SubItems[1].Text;
                    line += "|";
                    line += allListView.Items[i].SubItems[2].Text;
                    line += "|";
                    line += allListView.Items[i].SubItems[3].Text;
                    line += "|";
                    line += allListView.Items[i].SubItems[4].Text;
                    outputFile.WriteLine(line);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("No file saved.");
            }

        }

        private void loadListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Functionality not yet implemented.");
        }
    }
}
