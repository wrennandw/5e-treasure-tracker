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
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
            label1.Text = Controller.adventurerTabs.Count.ToString();
        }
    }
}
