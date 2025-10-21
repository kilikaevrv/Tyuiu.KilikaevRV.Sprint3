using System;
using Tyuiu.KilikaevRV.Sprint3.Task3.V9.Lib;

namespace Tyuiu.KilikaevRV.Sprint3.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Килькаев Р. В. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Килькаев Ренат Валерьевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву w в строке: 56hy vfe4r4 *");
            Console.WriteLine("* vf45b                                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "56hy vfe4r4 vf45b";
            char item = 'w';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Заменяемый символ: " + item);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string result = ds.ReplaceNumOnChar(value, item);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}