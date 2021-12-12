using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

namespace Core.Factory
{
    public class ProductFactory : Factory<Product>
    {
        public override void GetItems()
        {
            using (TextFieldParser parser = new TextFieldParser("../../../../products.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                parser.ReadFields(); // to skip first line
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    int id = Convert.ToInt32(fields[0]);
                    string name = Regex.Replace(fields[1],"<[^>]*>", String.Empty);
                    decimal price = Convert.ToDecimal(fields[2]);
                    bool active = Convert.ToBoolean(Convert.ToInt32(fields[3]));

                    if (fields[4] != "")
                    {
                        Items.Add(new SeasonalProduct(id, name, price, DateTime.Now < DateTime.Parse(fields[4]), DateTime.Now, DateTime.Parse(fields[4])));
                    }
                    else
                    {
                        Items.Add(new Product(id, name, price, active));    
                    }
                    
                    
                }
            }
        }
        
        
        
    }
}