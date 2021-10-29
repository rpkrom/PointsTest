using System;

namespace PointsTest
{
    class Program
    {
        static void Main(string[] args)
        {                                    // 1  15  5   15   90  49  60   52   250   0  26  41  150  0   0
            int[] transactions = new int[15] { 51, 65, 55, 65, 120, 99, 105, 101, 200, 23, 76, 91, 150, 16, 5 }; 

            Customer customer = new Customer { FName = "Robert", Transactions = transactions };

            CalculatePoints(customer);

            Console.WriteLine($"Customer {customer.FName} has a total of {customer.Points} points");
            Console.ReadLine();            
        }

        public static void CalculatePoints(Customer customer)
        {
            foreach (var amount in customer.Transactions)
            {
                if (amount >= 50 && amount < 100)
                {
                    // calculate total number from 50 to 100 and give one point per dollar
                    var baseline = 50;
                    var totalPoints = amount - baseline;              

                    customer.Points += totalPoints; // add single points               
                }
                if (amount >= 100)
                {
                    var baseline = 100;
                    var amountOverBaseline = amount - baseline;

                    var doublePoints = amountOverBaseline * 2; // double points over 100

                    var totalPoints = doublePoints + 50; 

                    customer.Points += totalPoints; // add double points
                }
            }    
        }
    }
    public class Customer
    {
        public string FName { get; set; }
        public int Points { get; set; }
        public int[] Transactions { get; set; }
    }
}
