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
    public partial class EditItemForm : Form
    {
        // Build the form and receive a reference to the main form
        private MainForm mainFormRef;
        int index;
        public EditItemForm(MainForm mainForm, ListViewItem item)
        {
            InitializeComponent();
            mainFormRef = mainForm;
            itemNameBox.Text = item.Text;
            quantityBox.Text = item.SubItems[1].Text;
            typeComboBox.Text = item.SubItems[2].Text;
            rarityComboBox.Text = item.SubItems[3].Text;
            if ((item.SubItems[4].Text) == "Yes")
            {
                attunementCheckbox.Checked = true;
            }
            else
            {
                attunementCheckbox.Checked = false;
            }
            index = item.Index;
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(quantityBox.Text);
                ListViewItem item = new ListViewItem(itemNameBox.Text);
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
                mainFormRef.editItem(item, index);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
