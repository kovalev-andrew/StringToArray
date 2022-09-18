using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static string[] StringToArray(string sentence)
        {
            //количество слов в предложении.
            //Служит для указания длины массива wordsFromSentence
            int wordsCounter = 1;

            //хранит в себе конкретный символ из предложения.
            //Служит для проверки наличия пробела
            char letterInSentence;

            //создаем новый класс StringBuilder для работы с текстом 
            StringBuilder sb = new StringBuilder();

            //этот алгоритм помогает понять количество слов в предложении.
            //Необходимо для понимания длины массива wordsFromSentence
            for (int i = 0; i < sentence.Length; i++) 
            {
                //проверяем по одному символу в предложении
                letterInSentence = sentence[i];

                //если пробел найден, значит в предложение на одно слово больше
                if (letterInSentence.ToString() == " ") wordsCounter ++; 
                
            }
            //массив, который хранит в себе слова из предложения
            string[] wordsFromSentence = new string[wordsCounter];

            //используем данную переменную для записи слов в массив
            wordsCounter = 0;

            //в этом цикле слова из предложения разделяются записываются в массив
            for (int i = 0; i < sentence.Length; i++) 
            {
                //проверяем по одной букве из массива
                letterInSentence = sentence[i];
                //проверка на наличие пробела
                if (letterInSentence.ToString() != " ")
                {
                    //если символ не является пробелом - добавляем его в текущее слово
                    sb.Append(letterInSentence);
                }
                else
                {
                    //добавляем текущее слово в массив
                    wordsFromSentence[wordsCounter] = sb.ToString();
                    sb.Remove(0, sb.Length);
                    //если пробел найден, значит слово закончилось и надо
                    //перейти на следующее. Добавляем единицу к счетчику слов
                    wordsCounter++;
                }
                if (i == sentence.Length - 1) wordsFromSentence[wordsCounter] = sb.ToString();
            }
            //возвращаем массив со словами
            return wordsFromSentence;

        }
        //этот метод выводит слова из массива в консоль
        static void PrintArray(string[] wordsInArray) 
        {
            Console.WriteLine("Слова из предложения в массиве:");
            for (int i = 0; i < wordsInArray.Length; i++)
            {
                Console.Write($"{wordsInArray[i]}\n"); 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            //вызываем метод, записывающий слова из предложения в массив
            string[] wordsFromSentence = StringToArray(sentence);
            //вызываем метод, который выводит на экран массив со словами
            PrintArray(wordsFromSentence); 
            Console.ReadKey();
        }
    }
}
