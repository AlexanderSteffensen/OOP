using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_1
{
    public class CompareCars : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (String.Compare(x.Make,y.Make) == 0)
            {
                if (String.Compare(x.Model,y.Model) == 0)
                {
                    if (x.Price < y.Price)
                    {
                        return -1;
                    }
                    if (x.Price > y.Price)
                    {
                        return 1;
                    }

                    return 0;
                }
                
                return -1 * String.Compare(x.Model, y.Model);
            }

            return -1 * String.Compare(x.Make, y.Make);
        }
    }
}