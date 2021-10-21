using System;
using System.Collections.Generic;

namespace Miniprojekt_1
{
    public class Menu : MenuItemTypes
    {
        public Menu(string title)
        {
            this.title = title;
        }
        public Menu(string title, MenuItem item1, MenuItem item2)
        {
            this.title = title;
            Add(item1);
            Add(item2);
        }
        
        private string title;
        private List<MenuItemTypes> menuItems = new List<MenuItemTypes>();
        private int choice;

        public void Add(MenuItemTypes menuitem)
        {
            menuItems.Add(menuitem);
        }

        public void Start()
        {
            Console.WriteLine(title);
            for (int i = 0; i < menuItems.Count; i++)
                Console.WriteLine(i+1 + ". " + menuItems[i].Title);

            Console.WriteLine("Please choose an option: ");
            
            choice = Convert.ToInt32(Console.ReadLine());
            
            menuItems[choice-1].Selected();
        }


        public void Selected()
        {
            Start();
        }

        public string Title
        {
            get
            {
                return title;
            }
        }
    }
}