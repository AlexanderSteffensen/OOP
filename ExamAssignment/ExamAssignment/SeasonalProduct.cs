using System;

namespace ExamAssignment
{
    public class SeasonalProduct : Product
    {
        public SeasonalProduct(int id, string name, decimal price, bool active, DateTime seasonstart, DateTime seasonend) : base(id, name, price, active)
        {
            
        }

        private DateTime SeasonStartDate;
        private DateTime SeasonEndDate;

    }
}