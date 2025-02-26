﻿using POO_CSharp_P20.Entities;
using POO_CSharp_P20.Services;
using System.Globalization;

namespace POO_CSharp_20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          /*  
          Restrições possíveis:
            • https://docs.microsoft.com/en-us/dotnet/csharp/programmingguide/generics/constraints-on-type-parameters
            • where T: struct • where T : class
            • where T : unmanaged
            • where T : new() • where T : <base type name>
            • where T : U
          */
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products:  ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list); // <Product> is optional

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(p);
        }
    }
}