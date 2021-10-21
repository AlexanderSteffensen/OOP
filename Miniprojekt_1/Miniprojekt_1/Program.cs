using System;
using System.IO;

namespace Miniprojekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("fancymenu");
            menu.Add(new MenuItem("Punkt1", "Hej med dig"));
            menu.Add(new MenuItem("Punkt2", "bøvs"));
            menu.Add(new MenuItem("Punkt3", "fodbold"));
            Menu underMenu = new Menu("undermenu");
            underMenu.Add(new MenuItem("test 1", "Jeg skal i byen i aften"));
            underMenu.Add(new MenuItem("test 2", "SKal have mange bajere :)"));
            menu.Add(underMenu);
            menu.Add(new InfiniteMenu("Uendelig menu"));
            menu.Add(new FileSystemMenu("Filmenu", new DirectoryInfo("/Users/alexandersteffensen/OneDrive - Aalborg Universitet")));
            menu.Start();
        }
    }
}