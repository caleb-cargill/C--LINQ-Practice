namespace LINQ.Practice.Models
{
	// Represents a product that can be purchased
	public class Product {
		public Product(string name, string brand, double cost) {
			Name = name;
			Brand = brand;
			Cost = cost;
		}
		
		public string Name { get; set; }
		public string Brand { get; set; }
		public double Cost { get; set; }

        public void Print() {
            Console.WriteLine($"Product {Name}, Brand {Brand}, ${Cost}");
        }
	}
}