using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
            numberOfCars++;
        }

        public static int numberOfCars = 0;

        public List<Car> Cars = new List<Car>();

    }
}

