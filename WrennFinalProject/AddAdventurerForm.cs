using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
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
                // Set the default portrait based on class selected
                string portraitPath = "..\\images\\";
                portraitPath += classSelectDropdown.Text;
                portraitPath += ".png";

                // Create the new tab
                Adventurer adventurer = new Adventurer(mainFormRef,
                    adventurerNameTextbox.Text, portraitPath);
                Controller.addAdventurer(adventurer);

                // Select the new tab
                int index = mainFormRef.treasureListTabControl.SelectedIndex;
                mainFormRef.treasureListTabControl.SelectTab(index + 1);

                // Add default class items if checked
                if (defaultGearCheckbox.Checked == true)
                {
                    // Set item source based on class selected
                    string filename = "..\\default_items\\";
                    filename += classSelectDropdown.Text;
                    filename += ".json";

                    // Start reading the file
                    StreamReader inputFile = new StreamReader(filename);
                    string currLine = inputFile.ReadLine();

                    // Parse into a JSON Node object
                    JsonNode defItems = JsonNode.Parse(currLine);

                    // Load coinage. New characters only have GP
                    int tempGp = defItems["coinage"]["gp"].GetValue<int>();
                    Controller.adventurerTabs[index+1]
                        .updateCoinage(0, tempGp);

                    // Create an array of JSON elements representing
                    // inventory items
                    var itemsArray = defItems["adventurerItem"].AsArray();
                    int numItems = itemsArray.Count;

                    // Add the items
                    for (int i = 0; i < numItems; ++i)
                    {
                        ListViewItem item = new ListViewItem(
                            defItems["adventurerItem"][i]
                            ["name"].ToString());
                        item.SubItems.Add(
                            defItems["adventurerItem"][i]
                            ["quantity"].ToString());
                        item.SubItems.Add(
                            defItems["adventurerItem"][i]
                            ["type"].ToString());
                        item.SubItems.Add(
                            defItems["adventurerItem"][i]
                            ["rarity"].ToString());
                        item.SubItems.Add(
                            defItems["adventurerItem"][i]
                            ["attunement"].ToString());
                        Controller.adventurerTabs[index+1]
                            .addItem(item);
                    }
                }
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
