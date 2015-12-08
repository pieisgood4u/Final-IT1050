using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int MaxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[MaxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {

            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;
            foreach (Passenger item in Occupants)
            {
                totalWeight += item.GetWeight();
            }
            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return this.GetCurrentWeight() > this.MaxWeight;
        }

    }
}
