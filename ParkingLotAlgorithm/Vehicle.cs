using System;

namespace ParkingLotAlgorithm
{
    public class Vehicle 
    {
        public int idOfVehicle = 0;
        public int numOfTires = 0;
        public int weightOfVehicle = 0;
        public string colorOfVehicle = "null";
        public string typeOfVehicle = "null";
        
        public int[] tireCount = { 2, 4 };
        public int[] weightsForVehicle = { 400, 2000, 2200, 2400, 2600, 2800, 3000 };
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
                return weightsForVehicle[random.Next(weightsForVehicle.Length)];
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
}
