using Disaheim_2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Amulet
    {

        private string itemId;
        private string design;
        private Level quality;


        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }


        public string Design
        {
            get { return design; }
            set { design = value; }
        }



        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        public Amulet(string itemId) : this(itemId, Level.medium, "")
        {
            this.itemId = itemId;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, "")
        {
            this.itemId = itemId;
            this.quality = quality;
        }

        public Amulet(string itemId, Level quality, string design)
        {
            this.itemId = itemId;
            this.quality = quality;
            this.design = design;
        }



        public override string ToString()
        {
            return "ItemId: " + itemId + ", " + "Quality: " + quality + ", " + "Design: " + design;
        }
    }


}
