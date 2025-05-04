/* 
Project name: WrennFinalProject
Author: Andrew Wrenn
Date: 4/20/2025
Description: A treasure and inventory tracker for D&D 5th Edition
Github: https://www.github.com/wrennandw/5e-treasure-tracker

> Default portraits sourced from the Dungeons & Dragons 5th Edition
Player's Handbook

> Coin icons (modified slightly) from https:// img.freepik.com/free-vector/
    realistic-coins-transparent-set-isolated-icons-with-gold-silver-bronze
    -colored-money-dime-items-vector-illustration_1284-78174.jpg

> Treasure chest (app icon) from https:// www.flaticon.com/free
    -icons/treasure-chest

I tried to keep my line lengths to 80 or less, but that's a lot trickier
with C# than with Python!
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
// I had to add the System.Text.Json package; I wanted to use JSON for my
// save/load system because I'm very familiar with it and prefer it to
// plaintext; I was surprised it doesn't have out of the box support.
using System.Text.Json;
using System.Reflection;
using System.Text.Json.Nodes;

namespace WrennFinalProject
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            Adventurer allTab = new Adventurer(this, 
                "Default", "..\\images\\Equipment.png");
            // Container for instantiated Adventurers
            Controller.addAdventurer(allTab);
            portraitBox.ImageLocation = "..\\images\\Equipment.png";
            Console.WriteLine("Initialized.");
        }

        // Update the Party Name field from the rename form
        public void updatePartyName(string name)
        {
            partyNameLabel.Text = name;
            
            // Adjust the party name font size based on length
            if (name.Length < 32)
            {
                partyNameLabel.Font = new Font("Book Antiqua", 24);
            }
            else if (name.Length < 36)
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
                var confirm = MessageBox.Show("Delete this item?",
                    "Delete Item", MessageBoxButtons.YesNo);

                // Delete the item if Yes is chosen
                if (confirm == DialogResult.Yes)
                {
                    Controller.adventurerTabs[tabIndex].removeItem(item);
                }

                // Deselect the item if No is chosen. Prevents an issue where
                // the item was still selected but not focused
                else
                {
                    Controller.adventurerTabs[tabIndex].treasureList.
                        SelectedItems.Clear();
                }
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
                    Controller.adventurerTabs[tabIndex].treasureList.
                    SelectedItems[0], tabIndex);
                editItemForm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No item is selected!");
            }
        }

        // Save button functionality
        // The Serialize function made this surprisingly easy
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
                try
                {
                    outputFile = File.CreateText(saveFileDialog.FileName);

                    // JSON serialization for save file
                    string name = JsonSerializer.Serialize(
                        partyNameLabel.Text);
                    outputFile.WriteLine(name);
                    for (int i = 0; i < Controller.adventurerTabs.Count; ++i)
                    {
                        Adventurer temp = Controller.adventurerTabs[i];
                        string jsonString = JsonSerializer.Serialize(temp);
                        outputFile.WriteLine(jsonString);
                    }
                    outputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No file saved.");
            }

        }

        // Load button functionality
        // This was a lot harder than I thought it would be,
        // because the Deserialize function kept giving me trouble
        // and I was probably going to have to rewrite the Adventurer
        // class to make it work, so this ended up being the better option
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

            // Check if the user actually opens a file
            // The function just terminates otherwise
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Log the Main Form so the deserializer can use it
                //Controller.logMainForm(this);

                // Clear all existing adventurers and items
                Controller.adventurerTabs[0].clearList();
                if (Controller.adventurerTabs.Count > 1)
                {
                    for (int i = Controller.adventurerTabs.Count - 1;
                        i > 0; --i)
                    {
                        treasureListTabControl.TabPages.RemoveAt(i);
                        Controller.removeAdventurer(i);
                    }
                }
                
                // Start reading the file
                StreamReader inputFile = new StreamReader(
                    openFileDialog.FileName);
                string currLine = inputFile.ReadLine();

                // Party name should be the first line
                try
                {
                    partyNameLabel.Text = JsonSerializer.Deserialize<string>
                    (currLine);
                }
                catch
                {
                    MessageBox.Show("Could not load. The save file appears" +
                        " to be corrupted.");
                    return;
                }
                
                int adventurerIndex = 0;
                                
                while (inputFile.EndOfStream == false)
                {
                    currLine = inputFile.ReadLine();
                    try
                    {
                        // Initialize temp variables
                        string tempPortrait;
                        string tempName;
                       
                        int tempGp;
                        int tempSp;
                        int tempCp;

                        // Parse into a JSON Node object
                        JsonNode currAdventurer = JsonNode.Parse (currLine);

                        // Read the data into temp variables
                        tempPortrait = currAdventurer["portraitPath"]
                            .ToString();
                        tempName = currAdventurer["adventurerName"]
                            .ToString();
                        tempGp = currAdventurer["coinage"]["gp"]
                            .GetValue<int>();
                        tempSp = currAdventurer["coinage"]["sp"]
                            .GetValue<int>();
                        tempCp = currAdventurer["coinage"]["cp"]
                            .GetValue<int>();

                        // Create an array of JSON elements representing
                        // inventory items
                        var itemsArray = currAdventurer["adventurerItem"]
                            .AsArray();
                        int numItems = itemsArray.Count;

                        // Handle the default tab
                        if (adventurerIndex == 0) {
                            
                            // Restore and update the portrait
                            Controller.adventurerTabs[0].portraitPath =
                                tempPortrait;
                            portraitBox.ImageLocation = tempPortrait;

                            Controller.adventurerTabs[0].adventurerName = 
                                tempName;
                            treasureListTabControl.SelectedTab.Text = tempName;

                            // Set the current coinage
                            gpTextBox.Text = tempGp.ToString();
                            spTextBox.Text = tempSp.ToString();
                            cpTextBox.Text = tempCp.ToString();
                        }

                        // Handle any subsequent tabs
                        else
                        {
                            // Create a new adventurer tab
                            Adventurer adventurer = new Adventurer(
                                this, tempName, tempPortrait);
                            Controller.addAdventurer(adventurer);
                        }

                        // Restore coinage
                        Controller.adventurerTabs[adventurerIndex].
                            updateCoinage(0, tempGp);
                        Controller.adventurerTabs[adventurerIndex].
                            updateCoinage(1, tempSp);
                        Controller.adventurerTabs[adventurerIndex].
                            updateCoinage(2, tempCp);

                        // Restore items
                        for (int i = 0; i < numItems; ++i)
                        {
                            ListViewItem item = new ListViewItem(
                                currAdventurer["adventurerItem"][i]
                                ["name"].ToString());
                            item.SubItems.Add(
                                currAdventurer["adventurerItem"][i]
                                ["quantity"].ToString());
                            item.SubItems.Add(
                                currAdventurer["adventurerItem"][i]
                                ["type"].ToString());
                            item.SubItems.Add(
                                currAdventurer["adventurerItem"][i]
                                ["rarity"].ToString());
                            item.SubItems.Add(
                                currAdventurer["adventurerItem"][i]
                                ["attunement"].ToString());
                            Controller.adventurerTabs[adventurerIndex]
                                .addItem(item);
                        }

                        // Increment to move to the next adventurer
                        adventurerIndex++;
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

        // Add a new adventurer tab/inventory
        private void addPartyMemberButton_Click(object sender, EventArgs e)
        {
            int index = treasureListTabControl.SelectedIndex;
            AddAdventurerForm addAdventurerForm = new AddAdventurerForm(
                this, index);
            addAdventurerForm.ShowDialog();
        }

        // Remove the selected adventurer and their inventory
        private void removePartyMemberButton_Click(object sender, EventArgs e)
        {
            int index = treasureListTabControl.SelectedIndex;
            
            // Prevent the first tab from being deleted
            if (treasureListTabControl.TabCount == 1)
            {
                MessageBox.Show("You cannot delete the last list!");
            }
            else
            {
                // Make sure the user wants to delete this adventurer
                var confirm = MessageBox.Show("Remove this adventurer? " +
                    "All items will be deleted.",
                    "Remove Adventurer", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    treasureListTabControl.TabPages.RemoveAt(index);
                    Controller.removeAdventurer(index);
                }
            }
        }

        // Update the portrait and coinage when a new tab is selected
        private void treasureListTabControl_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            string portraitPath = Controller.adventurerTabs[tabIndex].
                portraitPath;
            portraitBox.ImageLocation = portraitPath;
            gpTextBox.Text = Controller.adventurerTabs[tabIndex].coinage["gp"]
                .ToString();
            spTextBox.Text = Controller.adventurerTabs[tabIndex].coinage["sp"]
                .ToString();
            cpTextBox.Text = Controller.adventurerTabs[tabIndex].coinage["cp"]
                .ToString();
        }

        // Allow the user to load their own portrait images
        private void portraitBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)" +
                "|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string portraitPath = openFileDialog.FileName;
                int tabIndex = treasureListTabControl.SelectedIndex;
                Controller.adventurerTabs[tabIndex].updatePortrait(
                    portraitPath);
                portraitBox.ImageLocation = portraitPath;
            }
        }

        // Update the GP total when the GP amount is changed
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
                gpTextBox.Text = Controller.adventurerTabs[tabIndex].
                    revertCoinage(0).ToString();
                return;
            }
        }

        // Log the GP total when the box is selected (for error handling)
        private void gpTextBox_Selected(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            int gp = int.Parse(gpTextBox.Text);
            Controller.adventurerTabs[tabIndex].logOldCoinage(0, gp);
        }

        // Update the SP total when the GP amount is changed
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
                spTextBox.Text = Controller.adventurerTabs[tabIndex].
                    revertCoinage(1).ToString();
                return;
            }
        }
        
        // Log the SP total when the box is selected (for error handling)
        private void spTextBox_Selected(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            int sp = int.Parse(spTextBox.Text);
            Controller.adventurerTabs[tabIndex].logOldCoinage(1, sp);
        }

        // Update the CP total when the GP amount is changed
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
                cpTextBox.Text = Controller.adventurerTabs[tabIndex].
                    revertCoinage(2).ToString();
                return;
            }
        }

        // Log the CP total when the box is selected (for error handling)
        private void cpTextBox_Selected(object sender, EventArgs e)
        {
            int tabIndex = treasureListTabControl.SelectedIndex;
            int cp = int.Parse(cpTextBox.Text);
            Controller.adventurerTabs[tabIndex].logOldCoinage(2, cp);
        }

        // Display a form to rename the selected adventurer
        private void renameButton_Click(object sender, EventArgs e)
        {
            int index = treasureListTabControl.SelectedIndex;
            RenameAdventurerForm adventurerNameForm = 
                new RenameAdventurerForm(this, index);
            adventurerNameForm.ShowDialog();
        }
    }
}
