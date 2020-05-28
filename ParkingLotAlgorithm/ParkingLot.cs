using System;
using System.Threading;

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
}
