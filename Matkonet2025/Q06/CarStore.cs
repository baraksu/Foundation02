using System;

namespace Matkonet2025.Q06
{
    public class CarStore
    {
        public CarStore()
        {
            this.cars = new Car[500]; // Initialize with a fixed size array

        }

        private Car[] cars;

        public Car[] GetCars()
        {
            return this.cars;
        }
        public void SetCars(Car[] cars)
        {
            this.cars = cars;
        }
        public int LessAvgKm()
        {
            // Calculate the average km of all cars
            double totalKm = 0;
            int count = 0;

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null) // Check if the car is not null
                {
                    totalKm += cars[i].GetKm();
                    count++;
                }
            }
            // count > 0 to avoid division by zero
            double avgKm = totalKm / count;

            // Count how many cars have less than the average km
            Console.WriteLine($"Average km: {avgKm}");
            int lessThanAvgCount = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null && cars[i].GetKm() < avgKm)
                {
                    Console.WriteLine($"{cars[i].GetLicense()}");
                    lessThanAvgCount++;
                }
            }

            return lessThanAvgCount;
        }
    }
}