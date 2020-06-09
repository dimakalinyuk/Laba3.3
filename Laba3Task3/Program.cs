using System;
using System.Configuration;
using System.IO;

namespace Laba3Task3
{
    class Class1
    {
        static void Main()
        {
            string a = System.IO.File.ReadAllText(@"C:\Users\Діма\Desktop\Навчання\1 курс 2 семестр\ООП\Laba3\Laba3Task3\input.txt");
            int wordLen = 0;
            char[] chars = { ' ', ',' };
            string[] words = a.Split(chars);
            string path = @"C:\Users\Діма\Desktop\Навчання\1 курс 2 семестр\ООП\Laba3\Laba3Task3\output.txt";
            foreach (string word in words)
            {
                wordLen = word.Length;
                if (wordLen% 2 == 0)
                {
                    File.AppendAllText(path, word + " ");
                }
            }
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
