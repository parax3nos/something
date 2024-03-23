using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace countWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            string path = @"C:\Users\Evgeny\Desktop\ТИ\ST.txt";
            string text = File.ReadAllText(path);

            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            int[] counts = new int[alphabet.Length];

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (alphabet[i] == text[j])
                        counts[i]++;
                }
            }

            for (int i = 0; i < alphabet.Length - 33; i++)
            {
                Console.WriteLine($"{alphabet[i]} {counts[i] + counts[i + 33]}");
            }


            for (int i = 0; i < alphabet.Length; i++)
            {
                summ += counts[i];
            }
            Console.WriteLine($"summ = {summ}");
            Console.ReadLine();
        }
    }
}
