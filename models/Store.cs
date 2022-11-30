namespace LINQ.Practice.Models
{
	// Represents a retail store/shop
	public class Store {
		public string Name { get; set; }
		public List<Product> Products { get; set; } 
		public string Type { get; set; }
		public string Website { get; set; }

        public void Print() {
            Console.WriteLine($"Store: {Name}, Type: {Type}, URL: {Website}");
        }
	}
}