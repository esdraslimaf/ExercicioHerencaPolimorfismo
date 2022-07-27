using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Entities
{
    internal class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }  
        
       public UsedProduct(string name, double price, DateTime manufacturedate) : base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }

    }
}
