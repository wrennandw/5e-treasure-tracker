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
    public partial class GenerateTreasureForm : Form
    {
        // Build the form and receive a reference to the main form
        private MainForm mainFormRef;
        public GenerateTreasureForm(MainForm mainForm)
        {
            InitializeComponent();
            mainFormRef = mainForm;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
