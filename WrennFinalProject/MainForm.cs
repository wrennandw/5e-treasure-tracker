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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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

        public void addItem(ListViewItem item)
        {
            allListView.Items.Add(item);
        }

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
    }
}
