using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WrennFinalProject
{
    public static class Controller
    {
        public static List<Adventurer> adventurerTabs = new List<Adventurer>();
        
        public static void addAdventurer(Adventurer adventurer, int index, MainForm mainForm)
        {
            adventurerTabs.Add(adventurer);
            MainForm mainFormRef = mainForm;
        }

        public static void removeAdventurer(int index)
        {
            
            adventurerTabs.RemoveAt(index);
            
        }
    }
}
