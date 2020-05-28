using System;
using System.Collections.Generic;

namespace ParkingLotAlgorithm
{
    public class RunStatistics
    {
        public int totalVehicles = 1;
        public Dictionary<int, int> TireCount = new Dictionary<int, int>();
        public Dictionary<int, int> WeightCount = new Dictionary<int, int>();
        public Dictionary<string, int> ColorCount = new Dictionary<string, int>();

        public RunStatistics()
        {
            SetUpDictionaires();
        }
        public void SetUpDictionaires()
        {
            TireDictionary();
            WeightDictionary();
            ColorDictionary();

            void TireDictionary()
            {
                TireCount.Add(2, 0);
                TireCount.Add(4, 0);
            }
            void WeightDictionary()
            {
                WeightCount.Add(400, 0);
                WeightCount.Add(2000, 0);
                WeightCount.Add(2200, 0);
                WeightCount.Add(2400, 0);
                WeightCount.Add(2600, 0);
                WeightCount.Add(2800, 0);
                WeightCount.Add(3000, 0);
            }
            void ColorDictionary()
            {
                ColorCount.Add("white", 0);
                ColorCount.Add("black", 0);
                ColorCount.Add("red", 0);
                ColorCount.Add("orange", 0);
                ColorCount.Add("yellow", 0);
                ColorCount.Add("green", 0);
                ColorCount.Add("blue", 0);
            }
        }

        public void FactorStatistics()
        {
            var maxTires = TireCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine("Vehicles in the parking garage mostly have {0} tires.", maxTires);
            var mostCommonWeight = WeightCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine("Vehicles in the parking garage mostly weigh {0}lbs.", mostCommonWeight);
            var commonColor = ColorCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine("Vehicles in the parking garage are mostly {0}.", commonColor);
        }
        
    }
}
