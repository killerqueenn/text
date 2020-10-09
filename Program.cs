using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Threading;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ");  // пользователь вводит текст
            string Text = Console.ReadLine();
            char[] PuncMark = { '.', ',', ';', ':', '?', '!', '-', '(', ')'};     // массив с пунктуацией
            int howmanyPunctuationMarks = CountPunctuationMarks(Text, PuncMark); //количество знаков пунктуации
            string[] SplitSentense = SplitText( Text, PuncMark);     // отдельные предложения
            string longword = FindLongWord(allwords);     //длинное слово
            SplitWordInHalf(longword);
        }

        static int CountPunctuationMarks (string Text, char[] PuncMark)
        {
            int num = 0;
            foreach (char Punc in Text)
            {
                for (int i=0; i<9; i++)
                {
                    if (Punc == PuncMark[i])
                        num++;
                }
            }
            return num;
        }

        static string[] SplitText(string Text, char[] PuncMark)
        {
            string[] apart = Text.Split(PuncMark);
            return apart;
        }

        static string FindLongWord(List<string> allwords)
        {
            string longword = allwords[0];
            for (int i=1; i<allwords.Count; i++)
            {
                if (allwords[i].Length > longword.Length)
                {
                    longword = allwords[i];
                }
            }
            Console.WriteLine(longword);
            return longword;
        }

        static void  SplitWordInHalf(string  longword)
        {
            string halfofword = "";
            if (longword.Length % 2 == 0)
            {
                halfofword = longword.Substring(longword.Length / 2);
                Console.WriteLine(halfofword);
            }
            else
            {
                longword = longword.Remove(longword.Length / 2,1).Insert(longword.Length / 2, "*");
                Console.WriteLine(longword);
            }
        }
    }
}
