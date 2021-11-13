using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_2
{
    public class MyEnumerator : IEnumerator<int>
    {
        private RandomNNumbers count = new RandomNNumbers();
        private Random randomnum;
        private int min;
        private int max;
        
        public MyEnumerator(int seed, int min, int max)
        {
            randomnum = new Random(seed);
            this.min = min;
            this.max = max;
        }
        
        public bool MoveNext()
        {
            count.NewNumGenerated();
            Current = randomnum.Next(min, max);
            return true;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public int Current { get; private set;}

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}