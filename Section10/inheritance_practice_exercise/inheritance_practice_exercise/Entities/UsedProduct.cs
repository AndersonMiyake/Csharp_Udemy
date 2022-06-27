using System;
using System.Globalization;

namespace inheritance_practice_exercise.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return string.Format("{0} (used) $ {1} (Manufacture date: {2})",
                Name,
                Price.ToString("F2", CultureInfo.InvariantCulture),
                ManufactureDate.ToString("dd/MM/yyyy"));
        }
    }
}
