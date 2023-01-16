using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemCostsInput = "25.34\n10.99\n250.22\n21.87\n50.24\n15";
            string payerCountInput = "8\n";
            string individualCostInput = "52.24\n";

            byte[] buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            byte[] buffer2 = Encoding.UTF8.GetBytes(payerCountInput);
            byte[] buffer3 = Encoding.UTF8.GetBytes(individualCostInput);

            Console.WriteLine($"B1_IntegersOnlyNoTip - 음식값으로 정수만 입력하고 팁을 주지 않을 때\n");
            itemCostsInput = "12\n24\n53\n112\n52\n0";
            buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            using (StreamReader reader1 = new StreamReader(new MemoryStream(buffer1)))
            {
                double totalCost = RestaurantBillCalculator.CalculateTotalCost(reader1);
                Console.WriteLine($"정상 계산 값 : 265.65\n");
                Console.WriteLine($"실제 반환 값 : {totalCost}\n\n");
                Debug.Assert(totalCost == 265.65);
            }

            Console.WriteLine($"B2_IntegersOnlyWithTip - 음식값으로 정수만 입력하고 팁을 줄 때\n");
            itemCostsInput = "12\n24\n53\n112\n52\n12";
            buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            using (StreamReader reader1 = new StreamReader(new MemoryStream(buffer1)))
            {
                double totalCost = RestaurantBillCalculator.CalculateTotalCost(reader1);
                Console.WriteLine($"정상 계산 값 : 297.53\n");
                Console.WriteLine($"실제 반환 값 : {totalCost}\n");
                Debug.Assert(totalCost == 297.53);
            }

            Console.WriteLine($"\nB3_FloatingPointsNoTip - 음식값으로 실수를 입력하고 팁을 주지 않을 때\n");
            itemCostsInput = "21.23\n4.324\n3.12\n322.2\n52.0\n0";
            buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            using (StreamReader reader1 = new StreamReader(new MemoryStream(buffer1)))
            {
                double totalCost = RestaurantBillCalculator.CalculateTotalCost(reader1);
                Console.WriteLine($"정상 계산 값 : 423.02\n");
                Console.WriteLine($"실제 반환 값 : {totalCost}\n");
                Debug.Assert(totalCost == 423.02);
            }

            Console.WriteLine($"\nB4_FloatingPointsWithTip - 음식값으로 실수를 입력하고 팁을 줄 때\n");
            itemCostsInput = "21.23\n4.324\n3.12\n322.2\n52.0\n21";
            buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            using (StreamReader reader1 = new StreamReader(new MemoryStream(buffer1)))
            {
                double totalCost = RestaurantBillCalculator.CalculateTotalCost(reader1);
                Console.WriteLine($"정상 계산 값 : 511.85\n");
                Console.WriteLine($"실제 반환 값 : {totalCost}\n");
                Debug.Assert(totalCost == 511.85);
            }

            Console.WriteLine($"\nB5_IntergersAndFloatingPointsNoTip1 - 음식값으로 정수와 실수를 섞어 입력하고 팁을 주지 않을 때\n");
            itemCostsInput = "342\n2\n5.432\n112\n42.23\n0";
            buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            using (StreamReader reader1 = new StreamReader(new MemoryStream(buffer1)))
            {
                double totalCost = RestaurantBillCalculator.CalculateTotalCost(reader1);
                Console.WriteLine($"정상 계산 값 : 528.85\n");
                Console.WriteLine($"실제 반환 값 : {totalCost}\n");
                Debug.Assert(totalCost == 528.85);
            }

            Console.WriteLine($"\nB6_IntergersAndFloatingPointsWithTip - 음식값으로 정수와 실수를 섞어 입력하고 팁을 줄 때\n");
            itemCostsInput = "342\n2\n5.432\n112\n42.23\n78";
            buffer1 = Encoding.UTF8.GetBytes(itemCostsInput);
            using (StreamReader reader1 = new StreamReader(new MemoryStream(buffer1)))
            {
                double totalCost = RestaurantBillCalculator.CalculateTotalCost(reader1);
                Console.WriteLine($"정상 계산 값 : 941.34\n");
                Console.WriteLine($"실제 반환 값 : {totalCost}\n");
                Debug.Assert(totalCost == 941.34);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\nC1_TotalCostEqualToNumPayers - 총 가격이 돈 내는 손님 수와 같을 때\n");
            payerCountInput = "512\n";
            buffer2 = Encoding.UTF8.GetBytes(payerCountInput);
            using (StreamReader reader2 = new StreamReader(new MemoryStream(buffer2)))
            {
                double totalCost = 512;
                double individualCost = RestaurantBillCalculator.CalculateIndividualCost(reader2, totalCost);
                Console.WriteLine($"정상 계산 값 : 1\n");
                Console.WriteLine($"실제 반환 값 : {individualCost}\n");
                Debug.Assert(individualCost == 1);
            }

            Console.WriteLine($"\nC2_TotalCostLessthanNumPayers - 총 가격이 돈 내는 손님 수 보다 작을 때\n");
            payerCountInput = "512\n";
            buffer2 = Encoding.UTF8.GetBytes(payerCountInput);
            using (StreamReader reader2 = new StreamReader(new MemoryStream(buffer2)))
            {
                double totalCost = 3;
                double individualCost = RestaurantBillCalculator.CalculateIndividualCost(reader2, totalCost);
                Console.WriteLine($"정상 계산 값 : 0.01\n");
                Console.WriteLine($"실제 반환 값 : {individualCost}\n");
                Debug.Assert(individualCost == 0.01);
            }

            Console.WriteLine($"\nC3_TotalCostGreaterThanNumPayers - 총 가격이 돈 내는 손님 수 보다 클 때\n");
            payerCountInput = "3\n";
            buffer2 = Encoding.UTF8.GetBytes(payerCountInput);
            using (StreamReader reader2 = new StreamReader(new MemoryStream(buffer2)))
            {
                double totalCost = 512;
                double individualCost = RestaurantBillCalculator.CalculateIndividualCost(reader2, totalCost);
                Console.WriteLine($"정상 계산 값 : 170.67\n");
                Console.WriteLine($"실제 반환 값 : {individualCost}\n");
                Debug.Assert(individualCost == 170.67);
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\nD1_TotalCostEqIndividualCost - 총 가격이 각 개인이 내야하는 가격과 같을 때\n");
            individualCostInput = "1024.4201\n";
            buffer3 = Encoding.UTF8.GetBytes(individualCostInput);
            using (StreamReader reader3 = new StreamReader(new MemoryStream(buffer3)))
            {
                double totalCost = 1024.4201;
                uint payerCount = RestaurantBillCalculator.CalculatePayerCount(reader3, totalCost);
                Console.WriteLine($"정상 계산 값 : 1\n");
                Console.WriteLine($"실제 반환 값 : {payerCount}\n");
               // Debug.Assert(payerCount == 1);
            }

            Console.WriteLine($"\nD2_TotalCostGreaterThanIndividualCost - 총 가격이 각 개인이 내야하는 가격보다 클 때\n");
            individualCostInput = "1023.1382\n";
            buffer3 = Encoding.UTF8.GetBytes(individualCostInput);
            using (StreamReader reader3 = new StreamReader(new MemoryStream(buffer3)))
            {
                double totalCost = 1024.1382;
                uint payerCount = RestaurantBillCalculator.CalculatePayerCount(reader3, totalCost);
                Console.WriteLine($"정상 계산 값 : 2\n");
                Console.WriteLine($"실제 반환 값 : {payerCount}\n");
               // Debug.Assert(payerCount == 2);
            }

            Console.WriteLine($"\nD3_TotalCostLessThanIndividualCost - 총 가격이 각 개인이 내야하는 가격보다 작을 때\n");
            individualCostInput = "1023.1382\n";
            buffer3 = Encoding.UTF8.GetBytes(individualCostInput);
            using (StreamReader reader3 = new StreamReader(new MemoryStream(buffer3)))
            {
                double totalCost = 1;
                uint payerCount = RestaurantBillCalculator.CalculatePayerCount(reader3, totalCost);
                Console.WriteLine($"정상 계산 값 : 1\n");
                Console.WriteLine($"실제 반환 값 : {payerCount}\n");
              //  Debug.Assert(payerCount == 1);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
        }
    }
}
