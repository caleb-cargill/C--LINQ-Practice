using LINQ.Practice.Models;

namespace LINQ.Practice.Helpers
{
    public static class DataHelper 
    {
        // Get test data - a list of stores
        public static List<Store> GetStores() {
            List<Store> stores = new List<Store>();

            Dictionary<string, string> grocProds = 
                new Dictionary<string, string>
                { {"Banana", "Chiquita"}, {"Apple", "Granny"}, {"Bread", "Sara Lee"}, {"Milk", "Fair Life"}, {"Eggs", "Happy Egg"} };
            
            Dictionary<string, string> elecProds = 
                new Dictionary<string, string>
                { {"Phone", "Apple"}, {"TV", "LG"}, {"Laptop", "Dell"}, {"Headphones", "Apple"}, {"Camera", "LG"} };
            
            Dictionary<string, string> genProds 
                = new Dictionary<string, string>
                { {"Banana", "Chiquita"}, {"Apple", "Granny"}, {"Bread", "Sara Lee"}, {"Milk", "Fair Life"}, {"Eggs", "Happy Egg"}, {"Phone", "Apple"}, {"TV", "LG"}, {"Laptop", "Dell"}, {"Headphones", "Apple"}, {"Camera", "LG"} };
            
            Store walmart = new Store();
            walmart.Name = "Walmart";
            walmart.Type = "General";
            walmart.Website = "walmart.com";
            walmart.Products = genProds.Select(gp => new Product(gp.Key, gp.Value, gp.Key.Length)).ToList();
            stores.Add(walmart);
            
            Store target = new Store();
            target.Name = "Target";
            target.Type = "General";
            target.Website = "target.com";
            target.Products = genProds.Select(gp => new Product(gp.Key, gp.Value, gp.Value.Length)).ToList();
            stores.Add(target);
            
            Store bb = new Store();
            bb.Name = "Best Buy";
            bb.Type = "Electronics";
            bb.Website = "bestbuy.com";
            bb.Products = elecProds.Select(gp => new Product(gp.Key, gp.Value, gp.Key.Length * 10)).ToList();
            stores.Add(bb);
            
            Store meijer = new Store();
            meijer.Name = "Meijer";
            meijer.Type = "Grocery";
            meijer.Website = "meijer.com";
            meijer.Products = grocProds.Select(gp => new Product(gp.Key, gp.Value, gp.Key.Length)).ToList();
            stores.Add(meijer);
            
            Store aldi = new Store();
            aldi.Name = "Aldi";
            aldi.Type = "Grocery";
            aldi.Website = "aldi.com";
            aldi.Products = grocProds.Select(gp => new Product(gp.Key, gp.Value, gp.Key.Length)).ToList();
            stores.Add(aldi);
            
            return stores;
        }
    }
}