using System;

namespace ExamAssignment
{
    public class SeasonalProduct : Product
    {
        public SeasonalProduct(int id, string name, decimal price, bool active, DateTime seasonStart, DateTime seasonEnd) : base(id, name, price, active)
        {
            SeasonStartDate = seasonStart;
            SeasonEndDate = seasonEnd;
        }

        private DateTime SeasonStartDate;
        private DateTime SeasonEndDate;

    }
}