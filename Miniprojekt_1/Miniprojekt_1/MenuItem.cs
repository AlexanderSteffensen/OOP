using System;

namespace Miniprojekt_1
{
    public class MenuItem : MenuItemTypes
    {
        public MenuItem(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        private string title;

        public string Title
        {
            get
            {
                return title;
            }
        }


        private string content;

        public void Select()
        {
            Console.WriteLine(this.content);
        }

        public void Selected()
        {
            Select();
        }
    }
}