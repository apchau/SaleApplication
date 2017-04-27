using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Inventory
    {
        private string pId, pName;
        private int pStock;

        public Inventory(string id, string name, int stock)
        {
            pId = id;
            pName = name;
            pStock = stock;
        }

        public string ID
        {
            get { return pId; }
            set { pId = value; }
        }

        public string Name
        {
            get { return pName; }
            set { pName = value; }
        }

        public int Stock
        {
            get { return pStock; }
            set { pStock = value; }
        }

        public override string ToString()
        {
            return pId + ", " + pName + ", " + pStock.ToString();
        }
    }
}
