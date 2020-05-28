using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;

namespace ParkingLotAlgorithm
{
    public static class ParkingLot
    {
        public static int ParkingLotSize = 0;

        public static void GetParkingLotSize()
        {
            bool validInput = false;
            int userInput;

            do
            {
                Console.Write("Specify the size of the parking lot:\r\n" +
                              "Range of 0 to 500\r\n" +
                              "Input: ");
                Int32.TryParse(Console.ReadLine(), out userInput);
                // TODO: Add exception handle to catch characters and strings
                if (userInput >= 0 && userInput <= 500)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("The size must be 0 to 500.\r\n" +
                                      "Refreshing in 3 seconds.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            while (!validInput);
            ParkingLotSize = userInput;
        }

    }
    public class Vehicle 
    {
        public int idOfVehicle = 0;
        public int numOfTires = 0;
        public int weightOfVehicle = 0;
        public string colorOfVehicle = "null";
        public string typeOfVehicle = "null";
        
        public int[] tireCount = { 2, 4 };
        public int[] weightsForVehicle = { 2000, 2200, 2400, 2600, 2800, 3000 };
        public string[] colorsForVehicles = { "white", "black", "red", "orange", "yellow", "green", "blue" };

        public Vehicle()
        {
            idOfVehicle++;
            var random = new Random();
            numOfTires = GetNumOfTires();
            weightOfVehicle = GetWeightOfVehicle();
            colorOfVehicle = GetColorOfVehicle();
            typeOfVehicle = GetTypeOfVehicle(numOfTires);

            int GetNumOfTires()
            {
                return tireCount[random.Next(tireCount.Length)];
            }
            int GetWeightOfVehicle()
            {
                if (numOfTires == 2)
                {
                    return 400;
                }
                else
                {
                    return weightsForVehicle[random.Next(weightsForVehicle.Length)];
                }
            }
            string GetColorOfVehicle()
            {
                return colorsForVehicles[random.Next(colorsForVehicles.Length)];
            }
            string GetTypeOfVehicle(int tireCount)
            {
                if (tireCount == 2)
                {
                    return "motorcycle";
                }
                else
                {
                    return "sedan";
                }
            }
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot.GetParkingLotSize();
            Vehicle v = new Vehicle();
        }
    }
}
