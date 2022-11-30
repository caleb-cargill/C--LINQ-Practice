namespace LINQ.Practice.Models;

namespace LINQ.Practice
{
    public static class PracticeQuestions {

        // Test Data
        public static List<Store> Stores = DataHelper.GetStores();
        
        /***************************************************************************************************
        ****************************************** LINQ FILTERING ******************************************
        ***************************************************************************************************/
        
        /// WHERE - FILTERING 
        /// Get stores that are of type "Grocery"
        public static void LinqStmt1() {
            var results = Stores.Where(store => store.Type.Equals("Grocery"));
            Print(results.Select(store => store.Name));
        }
        
        /// ANY - FILTERING
        /// Check to see if there are any stores of type "Electronics"
        public static void LinqStmt2() {
            var results = Stores.Any(store => store.Type.Equals("Electronics"));
            Console.WriteLine(results);
        }
        
        /// ALL - FILTERING
        /// Check to see if all stores have a website (website is just a string)
        public static void LinqStmt3() {
            Console.WriteLine(Stores.All(s => !string.IsNullOrEmpty(s.Website)));
        }
        
        /// OF TYPE - FILTERING
        /// Get list of objects of type "Store" from objects list
        public static void LinqStmt4() {
            List<object> objects = Stores.Select(s => (object)s).ToList();
            objects.Add(new Product("iPhone", "Apple", 800));
            objects.Add(new Product("Table", "IKEA", 400));
            
            var results = objects.OfType<Store>();
            Print(results.Select(store => store.Website));
        }
        
        /***************************************************************************************************
        ****************************************** LINQ SELECTING ******************************************
        ***************************************************************************************************/
            
        /// SELECT - QUERY SPECIFIC DATA
        /// Get list of website from Stores
        public static void LinqStmt5() {
            var results = Stores.Select(store => store.Website);
            Print(results);
        }
        
        /// SELECT - TRANSFORM DATA
        /// Transform the list of stores into a list of products... pretend each store is a product
        public static void LinqStmt6() {
            var results = Stores.Select(store => new Product(store.Name, store.Website, 10));
            Print(results.Select(r => r.Name));
        }
        
        /// SELECT MANY - FLATTEN LISTS
        /// Get one large list of all products sold by all stores
        public static void LinqStmt7() {
            var results = Stores.SelectMany(store => store.Products);
            Print(results.Select(r => r.Name));
        }
        
        /***************************************************************************************************
        ****************************************** LINQ ORDERING *******************************************
        ***************************************************************************************************/
        
        /// ORDERING - ORDER ASCENDING
        /// Order the stores in ascending alphabetical order
        public static void LinqStmt8() {
            var results = Stores.OrderBy(s => s.Name);
            
            Print(results.Select(store => store.Name));
        }
        
        /// ORDERING - ORDER DESCENDING
        /// Order the products of a store in descending price
        public static void LinqStmt9() {
            Store store = Stores.First();
            var results = store.Products.OrderByDescending(x => x.Cost);
            
            Print(results.Select(p => p.Cost.ToString()));
        }
        
        /// ORDERING - CUSTOM COMPARER
        /// Order stores in ascending average price
        public static void LinqStmt10() {
            var results = Stores.OrderBy(s => s, new StoreAverageCostComparer());
            
            Print(results.Select(s => s.Products.Select(p => p.Cost).Average().ToString()));
        }
        
        /// Custom Comparer Class to Compare the average product cost of two stores
        public class StoreAverageCostComparer : System.Collections.Generic.Comparer<Store>
        {
            public override int Compare(Store s1, Store s2) {
                double avg1 = s1.Products.Select(p => p.Cost).Average();
                double avg2 = s2.Products.Select(p => p.Cost).Average();
                
                return avg1.CompareTo(avg2);
            }
        }

        /***************************************************************************************************
        ****************************************** LINQ GROUPING *******************************************
        ***************************************************************************************************/
        
        /// GROUPING - GROUP BY VALUE
        /// Group stores by store "Type"
        public static void LinqStmt11() {
            var results = Stores.GroupBy(x => x.Type);
            
            Print(results.SelectMany(r => r.Select(s => s.Name + " " + s.Type)));
        }
        
        /***************************************************************************************************
        ****************************************** LINQ JOINING ********************************************
        ***************************************************************************************************/
        
        /// JOINING - JOIN TWO LISTS
        public static void LinqStmt12() {

        }
        
        /***************************************************************************************************
        ******************************************** LINQ PAGING *******************************************
        ***************************************************************************************************/
        
        /// PAGING - TAKE FIRST 'X' VALUES
        public static void LinqStmt13() {

        }
        
        /// PAGING - SKIP FIRST 'X' VALUES
        public static void LinqStmt14() {

        }
        
        /// PAGING - SKIP FIRST 'X' VALUES, TAKE NEXT 'Y' VALUES
        public static void LinqStmt15() {

        }
        
        /***************************************************************************************************
        ****************************************** LINQ GET ELEMENT ****************************************
        ***************************************************************************************************/	

        /// ELEMENT - SINGLE
        public static void LinqStmt16() {
        
        }
        
        /// ELEMENT - SINGLE OR DEFAULT
        public static void LinqStmt17() {
        
        }
        
        /// ELEMENT - FIRST
        public static void LinqStmt18() {
        
        }
        
        /// ELEMENT - FIRST OR DEFAULT
        public static void LinqStmt19() {
        
        }
        
        /// ELEMENT - LAST
        public static void LinqStmt20() {
        
        }
        
        /// ELEMENT - LAST OR DEFAULT
        public static void LinqStmt21() {
        
        }
        
        /// ELEMENT - ELEMENT AT
        public static void LinqStmt22() {

        }
        
        /// CONVERTER - TO ARRAY
        public static void LinqStmt23() {

        }
        
        /***************************************************************************************************
        ****************************************** LINQ CONVERTERS *****************************************
        ***************************************************************************************************/
        
        /// CONVERTER - TO LIST
        public static void LinqStmt24() {

        }
        
        /// CONVERTER - TO DICTIONARY
        public static void LinqStmt25() {
        
        }
        
        /// CONVERTER TO LOOKUP
        public static void LinqStmt26() {
        
        }
        
        /***************************************************************************************************
        ****************************************** LINQ AGGREGATION ****************************************
        ***************************************************************************************************/	

        /// AGGREGATE - COUNT
        public static void LinqStmt27() {
            
        }
        
        /// AGGREGATE - MIN / MAX
        public static void LinqStmt28() {
                
        }
        
        /// AGGREGATE - SUM
        public static void LinqStmt29() {
                
        }

        /// AGGREGATE - AVERAGE
        public static void LinqStmt30() {
                
        }

        /***************************************************************************************************
        ****************************************** PRACTICE PROBLEMS ***************************************
        ***************************************************************************************************/

        /// PRACTICE QUESTION 1
        public static void PracticeQuestion1() {

        }
        
        /// PRACTICE QUESTION 2
        public static void PracticeQuestion2() {
                
        }
        
        /// PRACTICE QUESTION 3
        public static void PracticeQuestion3() {
            
        }
        
        /// PRACTICE QUESTION 4
        public static void PracticeQuestion4() {
                
        }
        
        /// PRACTICE QUESTION 5
        public static void PracticeQuestion5() {
                
        }
    }
}