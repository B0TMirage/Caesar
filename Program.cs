using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Murkach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] russianLetters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
                                                 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            char[] englishLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                 'y', 'z' };

            string newText = "";

            Console.WriteLine("Вас приветствует программа \"Шифр Егорыча\", работающая по алгоритмам \"Цезаря\".");
            Console.WriteLine("You are welcomed by the program \"Yegorych's Cipher\", which works according to the algorithms of \"Caesar\".\n");

            Console.WriteLine("Введите фразу, которую желаете закодировать: ");
            Console.WriteLine("Enter the phrase you want to encode: ");
            string text = Console.ReadLine();

            Console.WriteLine("На какое количество символов желаете сдвинуть фразу? ");
            Console.WriteLine("How many characters do you want to move the phrase by? ");
            int step = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                if (russianLetters.Contains(text[i]))
                {
                    int newWord = Array.IndexOf(russianLetters, text[i]) + step;
                    while (newWord >= russianLetters.Length)
                    {
                        newWord -= russianLetters.Length;
                    }
                    newText += russianLetters[newWord];
                } else if (englishLetters.Contains(text[i]))
                {
                    int newWord = Array.IndexOf(englishLetters, text[i]) + step;
                    while (newWord >= englishLetters.Length)
                    {
                        newWord -= englishLetters.Length;
                    }
                    newText += englishLetters[newWord];
                }
                else
                {
                    newText += text[i];
                }
            }
            Console.WriteLine(newText);
        }

    }
}
