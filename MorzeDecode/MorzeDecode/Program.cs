using System;
using System.Collections.Generic;

namespace MorzeDecode
{
    class Program
    {
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

        static void Main(string[] args)
        {
            string morzeText = WriteMessage();

            while(morzeText != "stop")
            {
                Console.WriteLine("\n{0} - декодированная строка\n", Decode(morzeText));

                morzeText = WriteMessage();
            }
            Console.WriteLine("Программа окончила работу");
        }

        static string WriteMessage()
        {
            Console.WriteLine("Введите текст для декодирования азбуки Морзе, чтобы окончить ввод введите stop:");
            return Console.ReadLine();
        }

        static string Decode(string morzeText)
        {
            string decodedText = "";
            string[] morzeString = morzeText.Split(" ");
            foreach (string symbol in morzeString)
            {
                if (symbol == "") {
                    decodedText += " ";
                    continue;
                }
                if (MorseCodeDictionary.ContainsKey(symbol))
                    decodedText += MorseCodeDictionary[symbol];
                else
                    decodedText += "*";
            }
            return decodedText;
        }
    }
}
