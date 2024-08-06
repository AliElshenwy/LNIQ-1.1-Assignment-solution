using static LNIQ_1._1_Assignment.Order;

namespace LNIQ_1._1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1==>1
            //var products = ListGenerator.GetProductsList();
            //var outOfStockProducts = products.Where(p => p.UnitsInStock == 0).ToList();

            //Console.WriteLine("all products that are out of stock");
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region 1==>2
            //var products = ListGenerator.GetProductsList();
            //var filteredProducts = products
            //    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M)
            //    .ToList();

            //Console.WriteLine("all products that are in stock and cost more than 3.00 per unit");
            //foreach (var product in filteredProducts)
            //{
            //    Console.WriteLine($"{product.ProductName}: ${product.UnitPrice} (In stock: {product.UnitsInStock})");
            //}
            #endregion

            #region 1==>3

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Select((name, index) => new { Name = name, Value = index })
            //    .Where(d => d.Name.Length < d.Value)
            //    .Select(d => d.Value)
            //    .ToList();

            //Console.WriteLine("");
            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region 2==>1
            //var products = ListGenerator.GetProductsList();
            //var sortedProducts = products
            //       .OrderBy(p => p.ProductName)
            //       .ToList();

            //Console.WriteLine("Products sorted by name:");
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"{product.ProductName}: ${product.UnitPrice} (In stock: {product.UnitsInStock})");
            //}
            #endregion

            #region 2==>2

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("Sorted words (case-insensitive):");
            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3==>1
            //var products = ListGenerator.GetProductsList();
            //var sortedProducts = products
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .ToList();

            //Console.WriteLine("Products sorted by units in stock (highest to lowest):");
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitsInStock} units");
            //}

            #endregion

            #region 3==>2

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // var sortedDigits = Arr
            //.OrderBy(name => name.Length)   
            //.ThenBy(name => name)           
            //.ToArray();

            //Console.WriteLine(" The List of Digits ");
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region 3==>3

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = words
            //      .OrderBy(word => word.Length)               
            //      .ThenBy(word => word, StringComparer.OrdinalIgnoreCase) 
            //      .ToArray();

            //Console.WriteLine("Words sorted by length and then case-insensitive alphabetical order:");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 4==>1

            //var sortedProducts = products
            //    .OrderBy(p => p.Category)             
            //    .ThenByDescending(p => p.UnitPrice)   
            //    .ToList();

            //// Output the sorted products
            //Console.WriteLine("Products sorted by category and then by unit price (highest to lowest):");
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"{product.Category} - {product.ProductName} - {product.UnitPrice:C}");
            //}



            #endregion

            #region 4==>2

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr
            //        .OrderBy(word => word.Length)  
            //        .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase) 
            //        .ToArray();

            //Console.WriteLine(" The Sorting");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 4==>3

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var filteredAndReversedDigits = Arr
            //        .Where(word => word.Length > 1 && word[1] == 'i')
            //        .Reverse()
            //        .ToList();

            //// Output the filtered and reversed array
            //Console.WriteLine("all digits in the array whose second letter is 'i'");
            //foreach (var digit in filteredAndReversedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion


        }
    }
    
}
