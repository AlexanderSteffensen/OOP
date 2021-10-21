using System;
using System.Collections.Generic;

namespace Miniprojekt_1
{
    public class InfiniteMenu : MenuItemTypes
    {
        public InfiniteMenu(string title)
        {
            this.title = title;
        }

        private string title;
        private List<InfiniteMenu> _infiniteMenus = new List<InfiniteMenu>();
        private int choice;
        public void Selected()
        {
            for (int i = 0; i < 6; i++)
                _infiniteMenus.Add(new InfiniteMenu("uendelig menu "+ (i+1)));
            
            Console.WriteLine(title);
            for (int i = 0; i < _infiniteMenus.Count; i++)
                Console.WriteLine(i+1 + ". " + _infiniteMenus[i].Title);

            Console.WriteLine("Please choose an option: ");
            
            choice = Convert.ToInt32(Console.ReadLine());
            
            _infiniteMenus[choice-1].Selected();
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