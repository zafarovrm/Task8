using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFilesTree(new DirectoryInfo(@"C:\Users\in-user\Desktop\Lab2"));
            Console.ReadKey();
        }
        static void GetFilesTree(DirectoryInfo root)
        {
            DirectoryInfo[] directories = root.GetDirectories();
            foreach (DirectoryInfo dir in directories)
            {
                GetFilesTree(dir);
                Console.WriteLine("Подкаталог: {0}", dir);
            }
            foreach (FileInfo file in root.GetFiles())
            {
                Console.WriteLine("Имя файла: {0}", file.Name);
            }
        }
    }
}