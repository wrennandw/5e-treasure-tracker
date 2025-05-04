using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WrennFinalProject
{
    // Static controller class for accessing Adventurer objects from any form
    public static class Controller
    {
        public static List<Adventurer> adventurerTabs = new List<Adventurer>();
        public static MainForm mainFormRef = new MainForm();

        public static void addAdventurer(Adventurer adventurer)
        {
            adventurerTabs.Add(adventurer);
        }

        public static void removeAdventurer(int index)
        {
            adventurerTabs.RemoveAt(index);
        }

        public static void logMainForm(MainForm mainForm)
        {
            mainFormRef = mainForm;
        }
    }
}
