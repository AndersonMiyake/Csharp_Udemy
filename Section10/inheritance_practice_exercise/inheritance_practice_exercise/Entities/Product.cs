using System.Globalization;

namespace inheritance_practice_exercise.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return string.Format("{0} $ {1}",
                Name,
                Price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
