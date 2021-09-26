using System.Collections;
using HomeWork.Models;

namespace HomeWork.Helpers
{
    public class PowerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            var xAnimal = x as Appliance;
            var yAnimal = y as Appliance;

            switch (xAnimal?.PowerConsumptionMax - yAnimal?.PowerConsumptionMax)
            {
                case >0:
                    return 1;
                case <0:
                    return -1;
            }

            return 0;
        }
    }
}