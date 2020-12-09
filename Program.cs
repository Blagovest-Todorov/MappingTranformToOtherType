using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.LinqTuition
{
    class Program
    {
        static void Main(string[] args)
        {
            var transformedInput = Console.ReadLine()
                                            .Split(' ')
                                            .Select(x => x.PadLeft( 5, 'c')); // move from the left wiht 5symbols, abnd print  the symbol 'c'
            Console.WriteLine(string.Join(", ", transformedInput));
        } // mappimng - > transform one element of a collection to another type element of other collection;
    }
}
