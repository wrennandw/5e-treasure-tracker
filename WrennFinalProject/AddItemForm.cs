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
        public AddItemForm(MainForm mainForm)
        {
            InitializeComponent();
            mainFormRef = mainForm;

            // Initialize the dropdowns to a default value
            typeComboBox.SelectedIndex = 0;
            rarityComboBox.SelectedIndex = 0;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(quantityBox.Text);
                ListViewItem item = new ListViewItem(itemNameBox.Text);
                item.SubItems.Add(quantityBox.Text);
                item.SubItems.Add(typeComboBox.Text);
                item.SubItems.Add(rarityComboBox.Text);
                mainFormRef.addItem(item);
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
