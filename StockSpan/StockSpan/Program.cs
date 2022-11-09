using System;
using System.Collections.Generic;

namespace StockSpan
{
    public class StockSpanner
    {
        public StockSpanner()
        {

        }

        List<int> stockPrices = new List<int>();
        public int Next(int price)
        {
            int numberOfDays = 1;

            if (stockPrices.Count == 0)
            {
                stockPrices.Add(price);
                return numberOfDays;
            }
            else
            {
                for (int i = 0; i < stockPrices.Count; i++)
                {
                    if (stockPrices[i] <= price)
                    {
                        numberOfDays++;
                    }

                    if (stockPrices[i] > price)
                    {
                        numberOfDays = 1;
                    }
                }
                stockPrices.Add(price);
                return numberOfDays;
            }
        }
        static void Main(string[] args)
        {
            StockSpanner stockSpanner = new StockSpanner();

            Console.WriteLine(stockSpanner.Next(100));
            Console.WriteLine(stockSpanner.Next(80));
            Console.WriteLine(stockSpanner.Next(60));
            Console.WriteLine(stockSpanner.Next(70));
            Console.WriteLine(stockSpanner.Next(60));
            Console.WriteLine(stockSpanner.Next(75));
            Console.WriteLine(stockSpanner.Next(85));
        }
    }
}
