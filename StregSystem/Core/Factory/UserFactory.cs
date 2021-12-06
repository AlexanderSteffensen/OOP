using System;
using Microsoft.VisualBasic.FileIO;

namespace Core.Factory
{
    public class UserFactory : Factory<User>
    {
        public override void GetItems()
        {
            using (TextFieldParser parser = new TextFieldParser("../../../../users.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields(); // to skip first line
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    int id = Convert.ToInt32(fields[0]);
                    string firstname = fields[1];
                    string lastname = fields[2];
                    string username = fields[3];
                    decimal balance = Convert.ToDecimal(fields[4]);
                    string email = fields[5];
                    

                    Items.Add(new User(id, firstname, lastname, username, balance, email));
                }
            }
        }
    }
}