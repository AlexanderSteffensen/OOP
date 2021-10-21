using System;
using System.IO;

namespace Miniprojekt_1
{
    public class FileSystemMenu : MenuItemTypes
    {
        public FileSystemMenu(string title, DirectoryInfo directoryInfo)
        {
            _title = title;
            _directoryInfo = directoryInfo;
        }

        private string _title;
        private DirectoryInfo _directoryInfo;


        public void Selected()
        {
            foreach (var fi in _directoryInfo.GetDirectories())
            {
                Console.WriteLine(fi.Name);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }
    }
}