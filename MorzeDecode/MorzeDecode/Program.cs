using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MorzeDecode
{
    public class Program
    {
        /**
         * Объявление словаря азбуки морзе
         */
        public static IDictionary<string, string> MorseCodeDictionary = new Dictionary<string, string>() {
             { ".-", "A"},
             { "-...", "B"},
             { "-.-.", "C"},
             { "-..", "D"},
             { ".", "E"},
             { "..-.", "F"},
             { "--.", "G"},
             { "....", "H"},
             { "..", "I"},
             { ".---", "J"},
             { "-.-", "K"},
             { ".-..", "L"},
             { "--", "M"},
             { "-.", "N"},
             { "---", "O"},
             { ".--.", "P"},
             { "--.-", "Q"},
             { ".-.", "R"},
             { "...", "S"},
             { "-", "T"},
             { "..-", "U"},
             { "...-", "V"},
             { ".--", "W"},
             { "-..-", "X"},
             { "-.--", "Y"},
             { "--..", "Z"},
        };

        static void Main()
        {
            // Вызываем функцию ввода строки
            string morzeText = WriteWord();

            // Цикл до тех пор пока строка не равна stop
            while (morzeText != "stop")
            {
                Console.WriteLine("\n{0} - декодированная строка\n", Decode(morzeText));

                morzeText = WriteWord();
            }
            Console.WriteLine("Программа окончила работу");
        }

        /**
         * Вывод сообщения с просьбой ввода строки, возврат введенной строки
         * return string
         */
        static string WriteWord()
        {
            Console.WriteLine("Введите текст для декодирования азбуки Морзе, чтобы окончить ввод введите stop:");

            return Console.ReadLine();
        }

        /**
         * Декодирование полученной в функции WriteMessage() строки
         * string morzeText
         * return string decodedText
         */
        public static string Decode(string morzeText)
        {
            string decodedText = "";
            // Разделяем строку по пробелам
            string[] morzeString = morzeText.Split(" ");
            foreach (string symbol in morzeString)
            {
                // Если было введено 2 пробела - значит новое слово
                if (symbol == "") {
                    decodedText += " ";
                    continue;
                }

                if (MorseCodeDictionary.ContainsKey(symbol))
                    decodedText += MorseCodeDictionary[symbol]; // Если нашлось вхождение в словарь, то добавляем букву
                else
                    decodedText += "*"; // Если не нашлось, то ставим звездочку на место буквы
            }
            return decodedText;
        }
    }

    [TestFixture]
    public class AutoTest
    {
        [Test]
        public void MorzeTest()
        {
            string[] morzeArray = { ".- -... -.-.  .---- ..--- ...--", ".... . .-.. .-.. ---  .-- --- .-. .-.. -.." };
            foreach (string morzeText in morzeArray) {
                Console.WriteLine("\n{0} - декодированная строка\n", Program.Decode(morzeText));
            }
        }
    }
}
