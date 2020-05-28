using System.Collections.Concurrent;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ParkingLotAlgorithm
{

    class Program
    {
        static void Main(string[] args)
        {
            int vehicleCounter = 1;
            ParkingLot.GetParkingLotSize();
            RunStatistics statistics = new RunStatistics();
            do
            {
                vehicleCounter++;
                Vehicle v = new Vehicle();

                statistics.totalVehicles++;
                statistics.TireCount[v.numOfTires] += 1;
                statistics.WeightCount[v.weightOfVehicle] += 1;
                statistics.ColorCount[v.colorOfVehicle] += 1;

            } while (vehicleCounter <= ParkingLot.ParkingLotSize);
            statistics.FactorStatistics();
        }
    }
}
