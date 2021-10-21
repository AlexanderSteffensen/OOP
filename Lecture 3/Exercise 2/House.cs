namespace Exercise_2
{
    public class House : FixedProperty, ITaxable
    {
        protected double area;

        public House(string location, bool inCity, double area, 
            decimal value):
            base(location, inCity, value){
            this.area = area;
        }

        public double Area{
            get{
                return area;
            }
        }

        public decimal TaxValue()
        {
            return 100;
        }
    }
}