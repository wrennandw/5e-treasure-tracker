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
    public partial class AddItemForm : Form
    {
        // Build the form and receive a reference to the main form
        private MainForm mainFormRef;
        private int tabIndex;
        public AddItemForm(MainForm mainForm, int index)
        {
            InitializeComponent();
            mainFormRef = mainForm;
            tabIndex = mainFormRef.treasureListTabControl.SelectedIndex;


            // Initialize the dropdowns to a default value
            typeComboBox.SelectedIndex = 3;
            rarityComboBox.SelectedIndex = 0;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(quantityBox.Text);
                ListViewItem item = new ListViewItem(itemNameBox.Text);
                // TODO: Remove "|" from any strings to prevent save issues
                item.SubItems.Add(quantityBox.Text);
                item.SubItems.Add(typeComboBox.Text);
                item.SubItems.Add(rarityComboBox.Text);
                // Changed from value in draft to attune
                // This is primarily because D&D handles item values
                // weirdly, and gives ranges more than concrete values
                // so it's hard to say what any given magical item is
                // actually worth
                if (attunementCheckbox.Checked)
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }
                Controller.adventurerTabs[tabIndex].addItem(item);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
