
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public abstract class Merchandise
    {
        string _itemId;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public Merchandise (string itemdId)
        {
            ItemId = itemdId;
        }
        public override string ToString()
        {
            return  "ItemId: " + ItemId;
        }
    }
}
