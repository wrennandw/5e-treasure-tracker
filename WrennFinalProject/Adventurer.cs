using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WrennFinalProject
{
    public class Adventurer
    {
        private MainForm mainFormRef;
        private TabPage tab = new TabPage();
        public ListView treasureList = new ListView();
        
        [JsonInclude]
        public string portraitPath;

        [JsonInclude]
        public string adventurerName;

        [JsonInclude]
        private List<Item> adventurerItem = new List<Item>();

        [JsonInclude]
        public Dictionary<string, int> coinage = new Dictionary<string, int>();

        // Trackers for coinage changes, to restore the value if a non-int is input
        [JsonInclude]
        private int oldGp = 0;
        [JsonInclude]
        private int oldSp = 0;
        [JsonInclude]
        private int oldCp = 0;

        // Constructor
        public Adventurer(MainForm mainForm, string name, string portrait)
        {
            mainFormRef = mainForm;
            adventurerName = name;
            portraitPath = portrait;

            // Initialize Gold, Silver, Copper
            this.coinage["gp"] = 0;
            this.coinage["sp"] = 0;
            this.coinage["cp"] = 0;

            // Create the base list
            this.tab.Text = adventurerName;

            // Initialize the ListView with the required properties

            this.treasureList.BorderStyle = BorderStyle.FixedSingle;
            this.treasureList.Columns.Add("Item Name", 175, HorizontalAlignment.Left);
            this.treasureList.Columns.Add("Quantity", 60, HorizontalAlignment.Left);
            this.treasureList.Columns.Add("Type", 105, HorizontalAlignment.Left);
            this.treasureList.Columns.Add("Rarity", 75, HorizontalAlignment.Left);
            this.treasureList.Columns.Add("Attunement", 75, HorizontalAlignment.Left);
            this.treasureList.Dock = DockStyle.Fill;
            this.treasureList.View = View.Details;
            this.treasureList.GridLines = true;
            this.treasureList.FullRowSelect = true;
            this.treasureList.Activation = ItemActivation.OneClick;

            // Add the list to the tab and the new tab to the tab control
            this.tab.Controls.Add(treasureList);
            mainFormRef.treasureListTabControl.TabPages.Add(this.tab);

            

        }

        // Add an item from the AddItem form
        public void addItem(ListViewItem item)
        {
            this.treasureList.Items.Add(item);
            int quantity = int.Parse(item.SubItems[1].Text);
            Item listItem = new Item(item.SubItems[0].Text, quantity, 
                item.SubItems[2].Text, item.SubItems[3].Text, 
                item.SubItems[4].Text);
            this.adventurerItem.Add(listItem);
        }

        // Edit an existing item from the EditItem form
        public void editItem(ListViewItem item, int index)
        {
            this.treasureList.Items[index] = item;
            int quantity = int.Parse(item.SubItems[1].Text);
            Item listItem = new Item(item.SubItems[0].Text, quantity, 
                item.SubItems[2].Text, item.SubItems[3].Text,
                item.SubItems[4].Text);
            this.adventurerItem[index] = listItem;
        }

        // Remove the selected item
        public void removeItem(ListViewItem item)
        {
            int index = item.Index;
            Item listItem = adventurerItem[index];
            item.Remove();
            adventurerItem.Remove(listItem);
        }

        // Clear the items list
        public void clearList()
        {
            treasureList.Items.Clear();
            adventurerItem.Clear();
        }

        // Updates the portrait path when the user selects a new one
        public void updatePortrait(string path)
        {
            this.portraitPath = path;
        }

        // Updates coinage when the text boxes in the main form change,
        // or on save/load
    }
}
