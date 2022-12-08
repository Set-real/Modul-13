using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QueueTest
{
    class Program
    {
        static void Main()
        {
            try
            {
                if (File.Exists(@"C:\Users\maest\Downloads\Text1.txt")) // Проверяю существует ли искомый файл
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start(); // Фиксирую время начала выполения программы

                    LinkedList<string> list = new LinkedList<string>(); // Инициализирую коллекцию

                    var wolf = list.Find("Обломов"); // Выбираю слово
                    if (wolf != null)
                        list.AddAfter(wolf, "Майкл Джексон"); // Произвожу вставку

                    foreach (var text in list)
                    {
                        Console.WriteLine(text); // Вывожу текст на косоль
                    }
                    sw.Stop(); // Фиксирую вреся окончания выполнения программы

                    Console.WriteLine($"Время выполения программы {sw.ElapsedMilliseconds}"); // Вывод времени выполнения программы на консоль
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }  
}