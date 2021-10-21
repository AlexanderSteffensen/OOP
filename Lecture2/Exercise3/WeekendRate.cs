namespace Exercise3
{
    public class WeekendRate : ParkingRate
    {
        private int minPrCoin;
        
        public WeekendRate(int minPrCoin)
        {
            this.minPrCoin = minPrCoin;
        }
    }
}