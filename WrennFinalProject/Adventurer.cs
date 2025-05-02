using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrennFinalProject
{
    public class Adventurer
    {
        private MainForm mainFormRef;
        public ListView treasureList = new ListView();
        private TabPage tab = new TabPage();
        public string portraitPath;

        // Constructor
        public Adventurer(MainForm mainForm, string name, string portrait)
        {
            mainFormRef = mainForm;
            string _name = name;

            portraitPath = portrait;

            // Platinum, Gold, Silver, Copper
            int[] _coinage = { 0, 0, 0, 0 };

            // Create the base list
            this.tab.Text = _name;

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

            // Select the new tab
            //int index = mainFormRef.treasureListTabControl.SelectedIndex;

        }

        public void updateList()
        {
            // TODO
            // Needs to update the list when treasure is added/removed/edited
        }

        // Add an item from the AddItem form
        public void addItem(ListViewItem item)
        {
            this.treasureList.Items.Add(item);
        }

        // Edit an existing item from the EditItem form
        public void editItem(ListViewItem item, int index)
        {
            this.treasureList.Items[index] = item;
        }

        // Remove the selected item
        public void removeItem(ListViewItem item)
        {
            item.Remove();
        }

        public void clearList()
        {
            treasureList.Items.Clear();
        }

        public void updatePortrait(string path)
        {
            this.portraitPath = path;
        }
    }
}
