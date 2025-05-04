using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WrennFinalProject
{
    public class Item
    {
        [JsonInclude]
        string name;
        [JsonInclude]
        int quantity;
        [JsonInclude]
        string type;
        [JsonInclude]
        string rarity;
        [JsonInclude]
        string attunement;

        public Item(string name, int quantity, string type, string rarity, string attunement)
        {
            this.name = name;
            this.quantity = quantity;
            this.type = type;
            this.rarity = rarity;
            this.attunement = attunement;
        }
    }
}
