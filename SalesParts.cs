﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesParts
{
    class SalesParts
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, List<Sale>>();
            for (int i = 0; i < number; i++)
            {
                var sale = ReadSale();
                if (!sales.ContainsKey(sale.Town))
                {
                    sales[sale.Town] = new List<Sale>();
                }
                sales[sale.Town].Add(sale);
            }
            foreach (var salesByTown in sales)
            {
                var town = salesByTown.Key;
                var sumOfSales = salesByTown.Value.Sum(s => s.Price *(decimal) s.Quantity);
                Console.WriteLine($"{town} -> {sumOfSales:f2}");
            }
        }
        static Sale ReadSale()
        {
            var saleParts = Console.ReadLine()
                .Split(' ');
            return new Sale
            {
                Town = saleParts[0],
                Product = saleParts[1],
                Price = decimal.Parse(saleParts[2]),
                Quantity = decimal.Parse(saleParts[3])
            };
        }
        
    }
}
 