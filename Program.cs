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

            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Path.Combine(myDocuments, "caesarLog.txt");

            string newText = "";
            string text;
            int step;

            Console.WriteLine("На каком языке будут производиться махинации? In what language will the fraud be carried out?");
            Console.WriteLine("1 - Русский\n2 - English");

            int currentLanguage = Convert.ToInt32(Console.ReadLine());

            switch (currentLanguage)
            {
                case 1:
                    Console.WriteLine("Вас приветствует программа \"Шифр Егорыча\", работающая по алгоритмам \"Цезаря\".");

                    Console.WriteLine("Введите фразу, которую желаете закодировать: ");
                    text = Console.ReadLine().ToLower();

                    Console.Write("На какое количество символов желаете сдвинуть фразу? ");
                    step = Convert.ToInt32(Console.ReadLine());

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
                        }
                        else
                        {
                            newText += text[i];
                        }
                    }
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine($"Была произведена манипуляция из: {text} в {newText}\n");
                    }
                    Console.WriteLine(newText);
                    break;
                case 2:
                    Console.WriteLine("You are welcomed by the program \"Yegorych's Cipher\", which works according to the algorithms of \"Caesar\".");

                    Console.WriteLine("Enter the phrase you want to encode: ");
                    text = Console.ReadLine().ToLower();

                    Console.Write("How many characters do you want to move the phrase by? ");
                    step = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (englishLetters.Contains(text[i]))
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
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine($"Manipulation was performed from: {text} to {newText}\n");
                    }
                    Console.WriteLine(newText);
                    break;
                default:
                    Console.WriteLine("Такой язык не обнаружен. No such language has been found.");
                    break;
            }
        }

    }
}
