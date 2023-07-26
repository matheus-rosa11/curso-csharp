using System.Globalization;

namespace Inheritance.Entities
{
    public class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {
            
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {manufactureDate:dd/MM/yyyy})";
        }
    }
}
