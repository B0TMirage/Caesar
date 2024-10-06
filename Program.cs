using System;
using System.Linq;

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

            char[] russianUpperLetters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц',
                                                      'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };

            char[] englishUpperLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 
                                                      'X', 'Y', 'Z' };

            Console.WriteLine("Вас приветствует программа \"Шифр Егорыча\", работающая по алгоритмам \"Цезаря\".");
            Console.WriteLine("You are welcomed by the program \"Yegorych's Cipher\", which works according to the algorithms of \"Caesar\".\n");

            Console.WriteLine("Введите фразу, которую желаете закодировать: ");
            Console.WriteLine("Enter the phrase you want to encode: ");
            string text = Console.ReadLine();

            Console.WriteLine("На какое количество символов желаете сдвинуть фразу? ");
            Console.WriteLine("How many characters do you want to move the phrase by? ");
            int step = Convert.ToInt32(Console.ReadLine());

            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (russianLetters.Contains(text[i]))
                {
                    int newLetter = Array.IndexOf(russianLetters, text[i]) + step;
                    while (newLetter >= russianLetters.Length)
                    {
                        newLetter -= russianLetters.Length;
                    }
                    newText += russianLetters[newLetter];
                } else if (englishLetters.Contains(text[i]))
                {
                    int newLetter = Array.IndexOf(englishLetters, text[i]) + step;
                    while (newLetter >= englishLetters.Length)
                    {
                        newLetter -= englishLetters.Length;
                    }
                    newText += englishLetters[newLetter];
                } else if (russianUpperLetters.Contains(text[i]))
                {
                    int newLetter = Array.IndexOf(russianUpperLetters, text[i]) + step;
                    while (newLetter >= russianUpperLetters.Length)
                    {
                        newLetter -= russianUpperLetters.Length;
                    }
                    newText += russianUpperLetters[newLetter];
                } else if (englishUpperLetters.Contains(text[i]))
                {
                    int newLetter = Array.IndexOf(englishUpperLetters, text[i]) + step;
                    while (newLetter >= englishUpperLetters.Length)
                    {
                        newLetter -= englishUpperLetters.Length;
                    }
                    newText += englishUpperLetters[newLetter];
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
