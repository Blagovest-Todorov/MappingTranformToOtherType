using System;
using System.Linq;
using System.Collections.Generic;



namespace _02.LinqTuition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[]
                { "John dow", "John Moe","John Foe", "Lisa Gradner"};

            //array = array.Select(x => x.Split(' ')[0]).ToArray(); // for every element in the string array, 
            //// split it by white space and take the first part of teh element 
            //Console.WriteLine(string.Join("  ", array));

            List<string> list = array.Select(x => x.Split(' ')[0]).ToList(); //selects arr elements, 
            // removes white space take the first element and converts it to list of string 
            // but only with the first name
            Console.WriteLine(string.Join(" ", list)); //here we print the content of the list as string array

        }
    }
}
