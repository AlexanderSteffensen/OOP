using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

namespace Core
{
    public class DataReader : IDataReader
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            using (TextFieldParser parser = new TextFieldParser("../../../../products.csv"))
            {
                SetupReader(parser, ";");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    
                    int id = Convert.ToInt32(fields[0]);
                    string name = Regex.Replace(fields[1], "<[^>]*>", String.Empty);
                    decimal price = Convert.ToDecimal(fields[2]);
                    bool active = Convert.ToBoolean(Convert.ToInt32(fields[3]));

                    if (fields[4] != "")
                    {
                        products.Add(new SeasonalProduct(id, name, price, DateTime.Now < DateTime.Parse(fields[4]),
                            DateTime.Now, DateTime.Parse(fields[4])));
                    }
                    else
                    {
                        products.Add(new Product(id, name, price, active));
                    }
                }
            }

            return products;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (TextFieldParser parser = new TextFieldParser("../../../../users.csv"))
            {
                SetupReader(parser, ",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    int id = Convert.ToInt32(fields[0]);
                    string firstname = fields[1];
                    string lastname = fields[2];
                    string username = fields[3];
                    decimal balance = Convert.ToDecimal(fields[4]);
                    string email = fields[5];
                    

                    users.Add(new User(id, firstname, lastname, username, balance, email));
                }
            }

            return users;
        }

        private void SetupReader(TextFieldParser parser, string delimiter)
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(delimiter);
            parser.ReadFields(); // to skip first line
        }
        
    }
}