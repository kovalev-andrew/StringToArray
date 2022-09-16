using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
            static void StringToArray(string sentence)
            {
                int wordsCounter = 1; //количество слов в предложении. Служит для указания длины массива wordsFromSentence
                char letterInSentence; //хранит в себе конкретный символ из предложения. Служит для проверки наличия пробела
                for (int i = 0; i < sentence.Length; i++) //этот алгоритм помогает понять количество слов в предложении. Необходимо для понимания длины массива wordsFromSentence
                {
                    letterInSentence = sentence[i]; //проверяем по одному символу в предложении
                    if (letterInSentence.ToString() == " ") wordsCounter++; //если пробел найден, значит в предложение на одно слово больше

                }
                string[] wordsFromSentence = new string[wordsCounter]; //массив, который хранит в себе слова из предложения
                wordsCounter = 0; //используем данную переменную для записи слов в массив
                for (int i = 0; i < sentence.Length; i++) //в этом цикле слова из предложения разделяются записываются в массив
                {
                    letterInSentence = sentence[i]; //проверяем по одной букве из массива
                    if (letterInSentence.ToString() != " ") //проверка на наличие пробела
                    {
                        wordsFromSentence[wordsCounter] += letterInSentence; //если символ не является пробелом - добавляем его в текущее слово
                    }
                    else
                    {
                        wordsCounter++; //если пробел найден, значит слово закончилось и надо перейти на следующее. Добавляем единицу к счетчику слов
                    }
                }
            PrintArray(wordsFromSentence); 

            }
            static void PrintArray(string[] wordsInArray) //этот метод выводит слова из массива в консоль
            {
                Console.WriteLine("Слова из предложения в массиве:");
                for (int i = wordsInArray.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{wordsInArray[i]}\n");
                }

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите предложение:");
                string sentence = Console.ReadLine();
                StringToArray(sentence); //вызываем метод, записывающий слова из предложения в массив
                Console.ReadKey();
            }
        }
}
