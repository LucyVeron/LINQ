/*
 * This program inserts 30 random letters into a List< char >. 
 * Performs the following queries on the List and displays your results.
 * 
 * a) Use LINQ to sort the List in ascending order
 * b) Use LINQ to sort the List in descending order
 * c) Display the list in ascending order with duplicates removed
 */
using System;
using System.Linq;
using System.Collections.Generic;

public class LinqProgram
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        List<int> list = new List<int>();

        /*Add 30 random lower-case letters to the list*/
        for (int i = 0; i < 30; i++)
        {
            /*Range values come from ASCII table*/
            list.Add(Convert.ToChar(rand.Next(97, 122)));
        }

        /*Display the characters*/
        Console.Write("Random letters: ");
        foreach (char i in list)
        {
            Console.Write(" {0}", i);
        }
        Console.WriteLine();

        /*Sort list in acscending order*/
        var sorted_ascend =
            from value in list
            orderby value
            select value;

        Console.Write("Sorted (ascending): ");
        foreach (var i in sorted_ascend)
        {
            Console.Write("{0} ", Convert.ToChar(i));
        }

        /*Sort list in descending order*/
        var sorted_descend =
            from value in list
            orderby value descending
            select value;

        Console.Write("Sorted (descending): ");
        foreach (var i in sorted_descend)
        {
            Console.Write("{0} ", Convert.ToChar(i));
        }
        
        /*Display list in ascending with no duplicates*/
        List<int> unique = list.Distinct().ToList();
        var sort_unique =
            from value in unique
            orderby value
            select value;

        Console.Write("Unique sorted: ");
        foreach (var i in sort_unique)
        {
            Console.Write("{0} ", Convert.ToChar(i));
        }
        Console.WriteLine();
    }
}
