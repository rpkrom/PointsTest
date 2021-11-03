using System;
using System.Collections.Generic;

namespace PointsTest
{
    class Program
    {
        static void Main(string[] args)
        {                                          // 1  15  5   15   90  49  60   52   250   0  26  41  150  0   0
            int[] transactionAmounts = new int[15] { 51, 65, 55, 65, 120, 99, 105, 101, 200, 23, 76, 91, 150, 16, 5 };

            Transactions transactions = new Transactions { SaleDate = DateTime.Now, SaleAmount = transactionAmounts };            
            
            Customer customer = new Customer {  FirstName = "Duke", LastName = "Leto", Transactions = transactions};

            CalculatePoints(customer);

            Console.WriteLine($"Customer {customer.FirstName} {customer.LastName}, has a total of {customer.RewardPoints} points");
            Console.ReadLine();
        }

        public static void CalculatePoints(Customer customer)
        {
            foreach (var saleAmount in customer.Transactions.SaleAmount)
            {
                if (saleAmount >= 50 && saleAmount < 100)
                {
                    // calculate total number from 50 to 100 and give one point per dollar
                    var baseline = 50;
                    var totalPoints = saleAmount - baseline;              

                    customer.ComparisonPoints += totalPoints; // add single points               
                }
                else if (saleAmount >= 100)
                {
                    var baseline = 100;
                    var amountOverBaseline = saleAmount - baseline;

                    var doublePoints = amountOverBaseline * 2; // double points over 100

                    var totalPoints = doublePoints + 50; 

                    customer.ComparisonPoints += totalPoints; // add double points
                }
            }    
        }

    }

}
