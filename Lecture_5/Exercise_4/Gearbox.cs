using System;
using System.Linq;

namespace Exercise_4
{
    public class Gearbox
    {
        public Gearbox(int gear)
        {
            if (!legalGears.Any(i => i == gear))
            {
                throw new ArgumentException();
            }
            else
            {
                _currentGear = gear;
            }
        }

        private int _currentGear;

        private int[] legalGears = { -1, 1, 2, 3, 4, 5 };
        
        void ChangeGear(int gear)
        {
            if (!legalGears.Any(i => i == gear))
            {
                throw new ArgumentException();
            }

            if (gear == -1 && _currentGear == 1 || (gear == _currentGear - 1 || gear == _currentGear + 1))
            {
                _currentGear = gear;
            }
            else
            {
                throw new IllegalGearChangeException();
            }
        }
    }
}