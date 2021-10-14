using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (@"C:\Users\in-user\Desktop\Log.txt");
            using (StreamReader sr = new StreamReader(path, true))
            {
                text = sr.ReadToEnd();
                string[] SMass;
                string str = sr.ReadLine();
                SMass = text.Split(' ');
                Console.WriteLine("Количество слов в тексте {0}", SMass.Length);
            }
        }
        static void vivod(string text)
        {
            int countwords = 0;// количество слов            
            if (text.Length == 0)
            {
                Console.WriteLine("Слов 0");
                return;
            }
            
            string[] lines = text.Trim(' ').Split(' ');
            for (int i = 0; i < lines.Length; ++i)
            {
                if (lines[i] != ".")
                {
                    char[] mas = lines[i].ToArray();
                    if (mas[mas.Length - 1] == '.')
                    {
                        countwords++;
                       
                    }
                    else
                        countwords++;
                }
                
            }
            
            Console.WriteLine("Слов: {0}", countwords);
            Console.ReadKey();
        }
    }
}
