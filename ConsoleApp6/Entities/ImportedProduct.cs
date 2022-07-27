using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsfee):base(name, price)
        {
            CustomsFee = customsfee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name}, ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }







    }
}
