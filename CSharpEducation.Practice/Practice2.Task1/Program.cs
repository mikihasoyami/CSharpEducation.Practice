using System.Dynamic;

namespace Practice2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Цикл for от 0 до 10
            WriteLogLine("Цикл For");
            for (int I = 0; I <= 10; I++)
            {
                WriteLog(I.ToString());
            }

            WriteLogLine("");
            WriteLogLine("Цикл While");

            // Цикл While
            int J = 0;
            while (J <= 10)
            {
                WriteLog(J.ToString());
                J++;
            }

            WriteLogLine("");
            WriteLogLine("do while");
            // Цикл Do while
            int K = 0;
            do
            {
                WriteLog(K.ToString());
                K++;
            } while (K <= 10);

            // Цикл for от 0 до 3 слов с выводом
            WriteLogLine("");
            WriteLogLine("Цикл For с вводом");
            string FullText = "";

            for (int I = 0; I < 3; I++)
            {
                string WordText = Console.ReadLine();
                WriteLogLine($"Вы ввели слово: {WordText}");
                if (I == 2)
                    FullText = FullText + WordText;
                else
                    FullText = FullText + WordText + " ";
            }
            WriteLog(FullText);

            // Цикл while от 0 до 3 слов с выводом
            WriteLogLine("");
            WriteLogLine("Цикл while с вводом");
            FullText = "";
            int L = 0;

            while (L < 3)
            {
                string WordText = Console.ReadLine();
                if (WordText != "")
                {
                    WriteLogLine($"Вы ввели слово в цикле While: {WordText}");
                    if (L == 2)
                        FullText = FullText + WordText;
                    else
                        FullText = FullText + WordText + " ";
                    L++;
                }
                else
                    WriteLogLine("Не введено слово");
            }
            WriteLog($"Суммарное словосочетание: {FullText}");

            // Цикл do while от 0 до 3 с выводом
            WriteLogLine("");
            WriteLogLine("Цикл do while с вводом");
            int N = 0;
            FullText = "";

            do
            {
                string WordText = Console.ReadLine();
                if (WordText != "")
                {
                    WriteLogLine($"Вы ввели слово в цикле While: {WordText}");
                    if (N == 2)
                        FullText = FullText + WordText;
                    else
                        FullText = FullText + WordText + " ";
                    N++;
                }
                else
                    WriteLogLine("Не введено слово");
            }
            while (N < 3);
            WriteLog($"Суммарное словосочетание: {FullText}");

        }

        static void WriteLogLine(string text)
        {
            Console.WriteLine(text);
        }

        static void WriteLog(string text)
        {
            Console.Write(text);
        }
    }
}
