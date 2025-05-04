/*
Project name: WrennFinalProject
Author: Andrew Wrenn
Date: 4/20/2025
Description: A treasure and inventory tracker for D&D 5th Edition
Github: https:// www/github.com/wrennandw/5e-treasure-tracker

Default portraits sourced from the Dungeons & Dragons 5th Edition Player's Handbook
Coin icons from https:// img.freepik.com/free-vector/realistic-coins-transparent-set-isolated-icons
    -with-gold-silver-bronze-colored-money-dime-items-vector-illustration_1284-78174.jpg
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
// I had to add the System.Text.Json package; I wanted to use JSON for my save/load system because
// I'm very familiar with it and prefer it to plaintext; I was surprised it doesn't have
// out of the box support.
using System.Text.Json;
using System.Reflection;

namespace WrennFinalProject
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            Adventurer allTab = new Adventurer(this, "All", "..\\images\\Equipment.png");
            // Container for instantiated Adventurers
            Controller.addAdventurer(allTab, 0, this);
            portraitBox.ImageLocation = "..\\images\\Equipment.png";


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
                
        private void addItemButton_Click(object sender, EventArgs e)
        {
            int index = treasureListTabControl.SelectedIndex;
            AddItemForm addItemForm = new AddItemForm(this, index);
            addItemForm.ShowDialog();
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Clear all items from this list?", 
                "Clear List", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                int tabIndex = treasureListTabControl.SelectedIndex;
                Controller.adventurerTabs[tabIndex].clearList();
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int tabIndex = treasureListTabControl.SelectedIndex;
                ListViewItem item = Controller.adventurerTabs[tabIndex].
                    treasureList.SelectedItems[0];
                Controller.adventurerTabs[tabIndex].removeItem(item);
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
                int tabIndex = treasureListTabControl.SelectedIndex;
                EditItemForm editItemForm = new EditItemForm(this,
                    Controller.adventurerTabs[tabIndex].treasureList.SelectedItems[0],
                    tabIndex);
                editItemForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No item is selected!");
            }
        }

        // Save button functionality
        private void saveListButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "..\\savedata";

            // Create the save directory if it doesn't already exist
            if (!Directory.Exists("..\\savedata"))
            {
                Directory.CreateDirectory("..\\savedata");
            }

            // For some reason setting the default path only works
            // with this disabled
            saveFileDialog.AutoUpgradeEnabled = false;

            // Initialize the StreamWriter object
            StreamWriter outputFile;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);

                ////////////////////////////
                //*****OLD SAVE LOGIC*****//
                //outputFile.WriteLine(partyNameLabel.Text);
                // Write the coinage values to the file first
                //string line = "";
                //line += gpTextBox.Text;
                //line += "|";
                //line += spTextBox.Text;
                //line += "|";
                //line += cpTextBox.Text;
                //line += "|";
                //outputFile.WriteLine(line);
                // Write each item to a line in the save file
                // Might change this to JSON encoding later
                //for (int i = 0; i < allListView.Items.Count; i++)
                //{
                /*line = allListView.Items[i].Text;
                line += "|";
                line += allListView.Items[i].SubItems[1].Text;
                line += "|";
                line += allListView.Items[i].SubItems[2].Text;
                line += "|";
                line += allListView.Items[i].SubItems[3].Text;
                line += "|";
                line += allListView.Items[i].SubItems[4].Text;
                outputFile.WriteLine(line);*/
                //}
                //*****END OLD SAVE LOGIC*****//
                ////////////////////////////////
                // Testing JSON serialization
                string name = JsonSerializer.Serialize(partyNameLabel.Text);
                outputFile.WriteLine(name);
                for (int i = 0; i < Controller.adventurerTabs.Count; ++i)
                {
                    Adventurer temp = Controller.adventurerTabs[i];
                    string jsonString = JsonSerializer.Serialize(temp);
                    //Console.Write(jsonString);
                    outputFile.WriteLine(jsonString);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("No file saved.");
            }

        }

        // Load button functionality
        private void loadListButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "..\\savedata";
            
            // Create the save directory if it doesn't already exist
            if (!Directory.Exists("..\\savedata"))
            {
                Directory.CreateDirectory("..\\savedata");
            }

            // For some reason setting the default path only works
            // with this disabled
            openFileDialog.AutoUpgradeEnabled = false;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear all existing adventurers and items
                Controller.adventurerTabs[0].clearList();
                for (int i = Controller.adventurerTabs.Count; i > 0; --i)
                {
                    treasureListTabControl.TabPages.RemoveAt(i);
                    Controller.removeAdventurer(i);
                }

                StreamReader inputFile = new StreamReader(openFileDialog.FileName);

                partyNameLabel.Text = inputFile.ReadLine();
                string currentLine;
                char delim = '|';
                currentLine = inputFile.ReadLine();
                string[] subItems = currentLine.Split(delim);
                gpTextBox.Text = subItems[1];
                spTextBox.Text = subItems[2];
                cpTextBox.Text = subItems[3];

                while (inputFile.EndOfStream == false)
                {
                    currentLine = inputFile.ReadLine();
                    subItems = currentLine.Split(delim);

                    try
                    {
                        ListViewItem item = new ListViewItem(subItems[0]);
                        item.SubItems.Add(subItems[1]);
                        item.SubItems.Add(subItems[2]);
                        item.SubItems.Add(subItems[3]);
                        item.SubItems.Add(subItems[4]);
                        //addItem(item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                inputFile.Close();
            }
        }

        private void addPartyMemberButton_Click(object sender, EventArgs e)
        {
            int index = treasureListTabControl.SelectedIndex;
            AddAdventurerForm addAdventurerForm = new AddAdventurerForm(this, index);
            addAdventurerForm.ShowDialog();
        }

        private void removePartyMemberButton_Click(object sender, EventArgs e)
        {
            int index = treasureListTabControl.SelectedIndex;
            
            // Prevent the first tab from being deleted
            if (index == 0)
            {
                MessageBox.Show("You cannot delete the main list!");
            }
            else
            {
                // Make sure the user wants to delete this adventurer
                var confirm = MessageBox.Show("Remove this adventurer? All items will be deleted.",
                    "Remove Adventurer", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    treasureListTabControl.TabPages.RemoveAt(index);
                    Controller.removeAdventurer(index);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebugForm debugForm = new DebugForm();
            debugForm.ShowDialog();
        }

        private void treasureListTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            string portraitPath = Controller.adventurerTabs[tabIndex].portraitPath;
            portraitBox.ImageLocation = portraitPath;

        }

        private void portraitBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string portraitPath = openFileDialog.FileName;
                int tabIndex = treasureListTabControl.SelectedIndex;
                Controller.adventurerTabs[tabIndex].updatePortrait(portraitPath);
                portraitBox.ImageLocation = portraitPath;
            }
        }

        private void gpTextBox_TextChanged(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            try 
            {
                int gp = int.Parse(gpTextBox.Text);
                Controller.adventurerTabs[tabIndex].updateCoinage(0, gp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                gpTextBox.Text = Controller.adventurerTabs[tabIndex].revertCoinage(0).ToString();
                return;
            }
        }

        private void gpTextBox_Selected(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            int gp = int.Parse(gpTextBox.Text);
            Controller.adventurerTabs[tabIndex].logOldCoinage(0, gp);
        }

        private void spTextBox_TextChanged(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            try
            {
                int sp = int.Parse(spTextBox.Text);
                Controller.adventurerTabs[tabIndex].updateCoinage(1, sp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                spTextBox.Text = Controller.adventurerTabs[tabIndex].revertCoinage(1).ToString();
                return;
            }
        }

        private void spTextBox_Selected(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            int sp = int.Parse(spTextBox.Text);
            Controller.adventurerTabs[tabIndex].logOldCoinage(1, sp);
        }

        private void cpTextBox_TextChanged(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            try
            {
                int cp = int.Parse(cpTextBox.Text);
                Controller.adventurerTabs[tabIndex].updateCoinage(2, cp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cpTextBox.Text = Controller.adventurerTabs[tabIndex].revertCoinage(2).ToString();
                return;
            }
        }
        private void cpTextBox_Selected(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            int cp = int.Parse(cpTextBox.Text);
            Controller.adventurerTabs[tabIndex].logOldCoinage(2, cp);
        }
    }
}
