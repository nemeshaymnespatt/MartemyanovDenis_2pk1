using System;

namespace pz_text.stroki
{
    internal class Program
    {
            static string[] BubbleSort(string[] str)
            {
                string temp;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int k = i + 1; k < str.Length; k++)
                    {
                        if (str[i].Length < str[k].Length)
                        {
                            temp = str[i];
                            str[i] = str[k];
                            str[k] = temp;
                        }
                    }
                }
                return str;
            }

            static void Main(string[] args)
            {

                Console.Write("Введите текст: ");
                string text = Console.ReadLine();

                string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Console.Write($"Количество слов: {words.Length}\n");

                Console.WriteLine(String.Join(" ", BubbleSort(words)));
            }
        }
    }

