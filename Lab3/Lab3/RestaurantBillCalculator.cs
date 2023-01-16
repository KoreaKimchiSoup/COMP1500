using System;
using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            double userCostInput1 = double.Parse(input.ReadLine());
            double userCostInput2 = double.Parse(input.ReadLine());
            double userCostInput3 = double.Parse(input.ReadLine());
            double userCostInput4 = double.Parse(input.ReadLine());
            double userCostInput5 = double.Parse(input.ReadLine());
            double userTip = double.Parse(input.ReadLine());

            double totalCostInput = userCostInput1 + userCostInput2 + userCostInput3 + 
                                                userCostInput4 + userCostInput5;
            double tax = totalCostInput * 0.05;
            double tip = (totalCostInput + tax) * userTip / 100;
            double totalCost = totalCostInput + tax + tip;
            double roundTotalCost = Math.Round(totalCost, 2);
            return roundTotalCost;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            uint individualCost = uint.Parse(input.ReadLine());
            double calculateIndividualCost = totalCost / individualCost;
            double rountCalculateIndividualCost = Math.Round(calculateIndividualCost, 2);

            return rountCalculateIndividualCost;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            Console.WriteLine(totalCost);
            double individualCostInput = double.Parse(input.ReadLine());
            double individualCost = totalCost / individualCostInput;
            double roundIndividualCost = Math.Ceiling(individualCost);

            return (uint)roundIndividualCost;
        }
    }
}