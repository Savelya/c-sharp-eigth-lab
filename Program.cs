using System;

namespace eigth_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");
            string[] words = str.Split(" ");

            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();

            Console.WriteLine("Введите k:");
            int k;
            if (!Int32.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Неправильный ввод.");
            }

            int count = 0;
            int countk = 0;
            foreach (string w in words)
            {
                count += (w == word) ? 1 : 0;
                countk += (Char.IsUpper(w[0])) ? 1 : 0;
                if (countk == k)
                {
                    Console.WriteLine("k-ое слово с заглавной буквы: " + w);
                    countk++;
                }
            }
            Console.WriteLine("Количество вхождений искомого слова в строку: " + count);
            words[words.Length - 2] = word;
            Console.Write("Строка с измененным предпоследним словом: " + String.Join(" ", words));
        }
    }
}
