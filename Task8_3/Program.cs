using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"C:\Users\in-user\Desktop\Log.txt");
            //Количество символов в тексте
            int sum = 0;
            using (StreamReader sr = new StreamReader(path, true))
            {
                string text = sr.ReadToEnd();
                foreach (char currStr in text)
                {
                    sum++;
                }
                Console.WriteLine("Количество символов: {0}", sum);
            }
            //Количество строк в тексте
            using (StreamReader sr = new StreamReader(path, true))
            {
                String line;
                Int32 lines = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    lines++;
                }
                Console.WriteLine("Количество строк: {0}", lines);
            }
            //Количество слов в тексте            
            string[] textMass;            
            using (StreamReader sr = new StreamReader(path, true))
            {
                string txt = sr.ReadToEnd();
                textMass = txt.Split(' ');
                Console.WriteLine("Количество слов: {0}", textMass.Length);
            }
            Console.ReadKey();
        }
    }
}