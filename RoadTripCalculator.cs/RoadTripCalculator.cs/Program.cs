///<summary>
/// RoadTripCalculator.cs
/// Description : Program calculates the total cost of a road trip based on distance, vehicle fuel efficiency, gas price, and snack costs, and allows the user to repeat the calculation.
/// Author : Jenny Trieu
/// Date : March 03 2026
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadTripCalculator.cs
{
    internal class Program
    {
        // Constant fuel efficiencies
        const double YOUR_FUEL_EFFICIENCY = 11.9;
        const double FRIEND_FUEL_EFFICIENCY = 8.7;
        private static double gasPrice;

        static void Main(string[] args)
        {
            //Declare Variables
            int distanceKm;
            string vehicleChoice;
            double fuelEfficiency;
            double fuelUsed;
            double fuelCost;
            int foodCost;
            double totalCost;
            string again;

            // Random number generator
            Random random = new Random();

            // Generate gas price once
            gasPrice = random.Next(140, 201) / 100.0;

            // Repeat the calculations until the user quits
            do
            {
                try
                {
                    // Ask user for trip distance
                    Console.Write("Enter trip distance in km: ");
                    distanceKm = int.Parse(Console.ReadLine());

                    // Ask which vehicle will be used
                    Console.Write("Use your car or your friend's? (y/f): ");
                    vehicleChoice = Console.ReadLine();

                    // Determine fuel efficiency
                    if (vehicleChoice == "y")
                    {
                        fuelEfficiency = YOUR_FUEL_EFFICIENCY;
                    }
                    else
                    {
                        fuelEfficiency = FRIEND_FUEL_EFFICIENCY;
                    }

                    // Calculate fuel used
                    fuelUsed = (distanceKm / 100.0) * fuelEfficiency;

                    // Calculate fuel cost
                    fuelCost = fuelUsed * gasPrice;

                    // Determine the snack cost based on distance
                    if (distanceKm < 200)
                    {
                        foodCost = 30;
                    }
                    else if (distanceKm <= 499)
                    {
                        foodCost = 50;
                    }
                    else if (distanceKm <= 999)
                    {
                        foodCost = 80;
                    }
                    else
                    {
                        foodCost = 120;
                    }

                    // Calculate total cost
                    totalCost = fuelCost + foodCost;

                    // Display results
                    Console.WriteLine($"\nGas price per L: ${gasPrice:F2}");
                    Console.WriteLine($"Fuel used: {fuelUsed:F2} L");
                    Console.WriteLine($"Fuel cost: ${fuelCost:F2}");
                    Console.WriteLine($"Food cost: ${foodCost:F2}");
                    Console.WriteLine($"Total trip cost: ${totalCost:F2}");
                }
                catch
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }

                // Ask the user if they want another calculation
                Console.Write("\nWould you like to calculate another trip? (y/n): ");
                again = Console.ReadLine();

            } while (again == "y");

            Console.WriteLine("Program ended.");
            Console.ReadKey();
        }
    }
}
