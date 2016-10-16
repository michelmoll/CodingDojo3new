using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.Models
{
    public class SoftwarePackages
    {
        

        public String Name { get; set; }
        public String Group { get; set; }
        public float SalesPrice { get; set; }
        public float PurchasePrice { get; set; }
        public int OnStock { get; set; }

        public SoftwarePackages(string name, string group, float salesPrice, float purchasePrice, int onStock)
        {
            Name = name;
            Group = group;
            SalesPrice = salesPrice;
            PurchasePrice = purchasePrice;
            OnStock = onStock;
        }
    }
}
