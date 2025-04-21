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
                // TODO Implement value conversions
                item.SubItems.Add("Not implemented");
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
