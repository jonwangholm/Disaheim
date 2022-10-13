using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim_2._0
{
    public class AmuletRepository
    {
        Utility utility = new Utility();
        private static List<Amulet> amulets = new List<Amulet>();

        public void addAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string ItemId)
        {
            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId == ItemId)
                {
                    return amulets[i];
                }
            }
            return null;
        }

        public double getTotalValue()
        {
            double pris = 0;
            for (int i = 0; i < amulets.Count; i++)
            {
                pris += utility.getValueOfAmulet(amulets[i]);
            }
            return pris;

        }
    }
}
