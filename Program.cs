using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.LinqTuition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> transformedInput = Console.ReadLine()     //string collection
                                            .Split(' ')   // Split returns a split array
                                            .Select(int.Parse)   // tranfroming string to integer
                                            .ToList();

            Console.WriteLine(transformedInput[5]); // this is how linq workes, tranforms here string to integer
            // move from the left wiht 5symbols, abnd print  the symbol 'c'
            Console.WriteLine(string.Join(", ", transformedInput));
        } // mappimng - > transform one element of a collection to another type element of other collection;
    }
}
