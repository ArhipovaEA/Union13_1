using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;


namespace Union13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> WorldBook = new List<string>();
            LinkedList<string> Book = new LinkedList<string>();
            // запускаем новый таймер
            var Watch1 = Stopwatch.StartNew();
            try
            {
                using (StreamReader sr = new StreamReader("D:\\Text1.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        WorldBook.Add(sr.ReadLine());
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не найден! " + e.Message);

            }


            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine($"Вставка в List<T>: {Watch1.Elapsed.TotalMilliseconds} мс");

            //// запускаем новый таймер
            var Watch2 = Stopwatch.StartNew();
            try
            {
                using (StreamReader sr2 = new StreamReader("D:\\Text1.txt"))
            {
                while (!sr2.EndOfStream)
                {
                    Book.AddLast(sr2.ReadLine());
                }
            }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл не найден! " + e.Message);

            }
            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine($"Вставка в LinkedList<T>: {Watch2.Elapsed.TotalMilliseconds} мс");

            Console.ReadLine();
            }
    }
}
