using System;
using System.Collections.Generic;
using System.Threading.Channels;
using DashSystem.Core;
using DashSystem.Core.Transactions;

namespace DashSystem.UI
{
    public class DashSystemCLI : IDashSystemUI
    {
        private IDashSystem _dashSystem;
        private bool _running;

        public DashSystemCLI(IDashSystem dashSystem)
        {
            _dashSystem = dashSystem;
        }

        public event CommandEntered UserEnteredCommand;

        public void DisplayUserNotFound(string username)
        {
            Console.WriteLine("User not found!");
        }

        public void DisplayProductNotFound(string product)
        {
            Console.WriteLine("Product not found!");
        }

        public void DisplayUserInfo(User user)
        {
            Console.WriteLine("User information:" +
                              "Full name :" + user.Firstname + " " + user.Lastname + "\n" +
                              "Username: " + user.Username + "\n" +
                              "E-mail: " + user.Email + "\n" +
                              "Balance" + user.Balance + "\n");
        }

        public void DisplayTooManyArgumentsError(string command)
        {
            Console.WriteLine("Command: " + command + " has too many arguments.");
        }

        public void DisplayAdminCommandNotFoundMessage(string adminCommand)
        {
            Console.WriteLine("Admin command not found!");
        }

        public void DisplayUserBuysProduct(BuyTransaction transaction)
        {
            Console.WriteLine("Bruger " + transaction.User + " købte 1 " + transaction.Product.Name + " til " + transaction.Amount);
        }

        public void DisplayUserBuysProduct(int count, BuyTransaction transaction)
        {
            Console.WriteLine("Bruger " + transaction.User + " købte " + count + " " + transaction.Product.Name + " til " + transaction.Amount);
        }

        public void Close()
        {
            Console.WriteLine("The program is closing...");
        }

        public void DisplayInsufficientCash(User user, Product product)
        {
            Console.WriteLine("User " + user.Username + " does not have enough cash to buy " + product.Name);
        }

        public void DisplayGeneralError(string errorString)
        {
            Console.WriteLine("An general error has occured.");
        }

        public void DisplayGeneralMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Start()
        {
            _running = true;
            DisplayWelcome();
            DisplayProducts();

            while (_running)
            {
                Console.Write("Skriv venligst din kommando: ");
                string command = Console.ReadLine();
                UserEnteredCommand?.Invoke(command); 
            }
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Velkommen til Stregsystemet, du kan sætte streger på følgende måde: \n" +
                              "- Indtast din brugernavn og et produkt ID (adskilt med mellemrum). " +
                              "Købet vil da blive registreret uden yderligere indput." +
                              "Der vil vises en bekræftelse af købet.\n");
        }

        public void DisplayProducts()
        {
            foreach (Product product in _dashSystem.ActiveProducts)
            {
                Console.WriteLine(product.ID + ". "+ product.Name + " " + product.Price);
            }
            Console.WriteLine();
        }

        //public event StregsystemEvent CommandEntered;
    }
}