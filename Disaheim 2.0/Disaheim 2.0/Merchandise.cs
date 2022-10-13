using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public abstract class Merchandise
    {
        private string itemId;
        public string ItemId
        {
            get { return itemId; }

            set { itemId = value;  }
        }
        public override string ToString()
        {
            return "gg";
        }





    }
}
