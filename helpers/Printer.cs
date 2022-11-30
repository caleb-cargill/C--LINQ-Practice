using LINQ.Practice.Models;

namespace LINQ.Practice.Helpers
{

    public static class Printer<T> {

        // PRINTS OUT AN IENUMERABLE OF GENERIC T
        public static void Print<T>(IEnumerable<T> items) {
            foreach (T item in items)
                item.Print();

        }

        // PRINTS OUT AN ARRAY OF GENERIC T
        public static void Print<T>(T[] items) {
            foreach (T item in items)
                item.Print();
        }

        // PRINTS OUT AN IENUMERABLE OF STRING
        public static void Print(IEnumerable<string> values) {
            foreach (string val in values)
                Console.WriteLine(val);
        }
        
        // PRINTS OUT AN ARRAY OF STRING
        private static void Print(string[] values) {
            foreach (string val in values)
                Console.WriteLine(val);
        }
    }
}