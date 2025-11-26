using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расчет_кол_ва_уровней__длинный_вариант_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();

            Console.WriteLine("Задайте верхнюю цену: ");

            string str = Console.ReadLine();

            decimal priceUp = decimal.Parse(str);

            Console.WriteLine("Задайте нижнюю цену: ");

            str = Console.ReadLine();

            decimal priceDown = decimal.Parse(str);

            Console.WriteLine("Введите шаг уровня: ");

            str = Console.ReadLine();

            decimal stepLevel = decimal.Parse(str);

            decimal priceLevel = priceUp;

            int countLevels = (Convert.ToInt32(priceUp) - Convert.ToInt32(priceDown)) / Convert.ToInt32(stepLevel);

            Console.WriteLine("Кол-во уровней: " + countLevels);

            for (int i = 0; i < countLevels; i++)
            {
                levels.Add(priceLevel);

                priceLevel -= stepLevel;
            }

            WriteLine();

            Console.ReadLine();
        }

        static List<decimal> levels = new List<decimal>();
        static void WriteLine()
        {
            Console.WriteLine("Кол-во элементов в списке: " + levels.Count.ToString());

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine(levels[i]);
            }
            
        }
    }
}
