using System.Globalization;

namespace inheritance_practice_exercise.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string PriceTag()
        {
            return string.Format("{0} $ {1} (Customs fee: $ {2}",
                Name,
                TotalPrice().ToString("F2", CultureInfo.InvariantCulture),
                CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
