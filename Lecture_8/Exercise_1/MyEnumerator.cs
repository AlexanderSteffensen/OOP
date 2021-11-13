using System.Collections;
using System.Collections.Generic;

namespace Exercise_1
{
    public class MyEnumerator : IEnumerator<int>
    {
        private int count;
        private int steps;
        private int skip;
        public MyEnumerator(int current, int count, int skip)
        {
            Current = current;
            this.count = count;
            steps = 0;
            this.skip = skip;
        }
        
        public bool MoveNext()
        {
            steps++;
            if (steps < count)
            {
                Current += skip;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public int Current { get; private set; }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}