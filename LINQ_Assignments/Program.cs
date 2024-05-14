using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using static LINQ_Assignments.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace LINQ_Assignments
{
    internal class Program
    {

        class Equalitycomparer : IEqualityComparer<string>
        {
            public bool Equals(string? x, string? y)
            {
                return sort(x) == sort(y);
            }

            public int GetHashCode([DisallowNull] string obj)
            {
                return sort(obj).GetHashCode();
            }


            string sort(string obj)
            {
                var word = obj.ToCharArray();

                Array.Sort(word);

                return new string(word);

            }
        }

        class CustomComparer : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }
        }

        static void Main(string[] args)
        {
            //Note: Use ListGenerators.cs & Customers.xml


            #region Assignment 1 LINQ



            #region LINQ - Restriction Operators

            #region 1.Find all products that are out of stock.

            //var result = ProductsList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3m);

            //foreach (var item in result)
            //    Console.WriteLine(item);



            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((n,i) => n.Length < i);

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #endregion


            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 

            //var result = ProductsList.Where(p => p.UnitsInStock == 0 ).FirstOrDefault();

            //Console.WriteLine(result);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(result?.ProductName?? "Not Found");

            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(n => n > 5).ElementAt(1);

            //Console.WriteLine(result);




            #endregion


            #endregion


            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Count(i => i % 2 == 1);

            //Console.WriteLine(result);


            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var result = CustomersList.Select(c => new
            //{
            //    c.CustomerName,
            //    OrderCount = c.Orders.Count()

            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var result = ProductsList.Select(p => new
            //{
            //    Category = p.Category,
            //    NumberOfProducts = ProductsList.Count(c => c.Category == p.Category)

            //}).ToHashSet();

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();
            //Console.WriteLine(result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Sum(x => x.Length);
            //Console.WriteLine(result);


            #endregion



            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Min(x => x.Length);
            //Console.WriteLine(result);


            #endregion


            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Max(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var result = words.Average(w => w.Length);
            //Console.WriteLine(result);

            #endregion


            #region 9 . Get the average price of each Category's products

            //var result = ProductsList.GroupBy(c => c.Category).Select(p => new
            //{
            //    category = p.Key,
            //    AvgPrice = p.Average(i =>i.UnitPrice)
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion


            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var result = ProductsList.OrderBy(p => p.ProductName);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x, new CustomComparer());

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(d => d.Length).ThenBy(d => d);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w.Length).ThenBy(b => b , StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w.Length).ThenByDescending(b => b, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(w => w[1] == 'i').Reverse();

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion


            #endregion


            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var result = ProductsList.Select(p => p.ProductName);

            //foreach (var item in result)
            //    Console.WriteLine(item);



            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //{
            //    upperCase = w.ToUpper(),
            //    lowerCase = w.ToLower(),
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductsList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price = p.UnitPrice
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 4. Determine if the value of int in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((n, i) => new
            //{
            //    Number = n,
            //    x = n==i
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };

            //foreach (var item in result)
            //    Console.WriteLine($"{item.a} is less than {item.b}");


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var result = CustomersList.SelectMany(o => o.Orders).Where(o => o.Total < 500);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            //=

            //var result = from c in CustomersList
            //             from o in c.Orders
            //             where o.Total < 500
            //             select o;

            //foreach (var item in result)
            //    Console.WriteLine(item);



            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var result = CustomersList.SelectMany(o => o.Orders).Where(o => o.OrderDate.Year >= 1998);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion


            #endregion

            #endregion




            //=========================================================================//



            #region Assignment 2 LINQ


            #region LINQ - Aggregate Operators


            #region 1.Find the unique Category names from Product List

            //var result = ProductsList.Select(c => c.Category).Distinct();

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion


            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var result = ProductsList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion


            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var result = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion


            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var result = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0]));

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var result = ProductsList.Select(p => p.ProductName[^3..]).Concat(CustomersList.Select(c => c.CustomerName[^3..]));

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion



            #endregion


            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington.

            //var result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Take(3);

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var result = CustomersList.Where(c => c.Region == "WA").SelectMany(o => o.Orders).Skip(2);

            //foreach (var item in result)
            //    Console.WriteLine(item);


            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, i) => n > i);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(n => n%3 != 0);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((n, i) => n > i);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion


            #endregion


            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            // var Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.Any(w => w.Contains("ei"));

            //Console.WriteLine(result);

            #endregion

            #region 2. Return a grouped list of products only for categories that have at least one product that is out of stock.

            //var result = ProductsList.GroupBy(c => c.Category)
            //                         .Where(c => c.Any(p => p.UnitsInStock == 0))
            //                         .Select(p => p);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var p in item)
            //        Console.WriteLine(p);
            //}


            #endregion

            #region 3. Return a grouped list of products only for categories that have all of their products in stock.

            //var result = ProductsList.GroupBy(c => c.Category).Where(c => c.All(p => p.UnitsInStock > 0));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var p in item)
            //        Console.WriteLine(p);
            //}

            #endregion







            #endregion


            #region LINQ – Grouping Operators

            #region 1.	Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Remainder of {item.Key}");
            //    foreach (var num in item)
            //        Console.WriteLine(num);

            //}


            #endregion

            #region 2.	Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input

            //var Words = File.ReadAllLines("dictionary_english.txt");

            //var result = Words.GroupBy(w => w[0]);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Words Start With Letter {item.Key}");
            //    foreach (var subitem in item)
            //        Console.WriteLine(subitem);

            //}

            #endregion

            #region 3.	Consider this Array as an Input. Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var result = Arr.GroupBy(w => w.Trim(), new Equalitycomparer());

            //foreach (var word in result)
            //{
            //    foreach (var item in word)
            //    {
            //        Console.WriteLine(item);
                    
            //    }

            //    Console.WriteLine("--------------------");


            //}


            #endregion



            #endregion


            #endregion



        }
    }
}
