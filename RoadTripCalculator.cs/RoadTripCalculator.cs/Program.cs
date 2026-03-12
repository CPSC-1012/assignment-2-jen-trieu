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

                    
        }
    }
}
