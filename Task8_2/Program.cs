using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"C:\Users\in-user\Desktop\Log.txt");
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(100));
                }
            }
            Int32 sum = 0;
            String currStr = null;
            using (StreamReader sr = new StreamReader(path, true))
                for (int j = 0; j < 10; j++)
                {
                    currStr = sr.ReadLine();
                    sum += Int32.Parse(currStr);
                }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}