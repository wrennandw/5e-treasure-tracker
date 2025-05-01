using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WrennFinalProject
{
    class Adventurer
    {
        public Adventurer(string name, ListViewItem treasureList, string portraitPath, int[] coinage) 
        {
            string _name = name;
            ListViewItem _treasureList = treasureList;
            string _portraitPath = portraitPath;
            int[] _coinage = coinage;
        }
        
        public void updateList()
        {
            // TODO
            // Needs to update the list when treasure is added/removed/edited
        }

    }
}
