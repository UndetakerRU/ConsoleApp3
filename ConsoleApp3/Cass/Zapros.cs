using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Cass
{
    internal class Zapros
    {

        public double[] GetNumbers()
        {
            // Создаем список для хранения чисел
            var numbers = new List<double>();

            // Запрашиваем числа у пользователя


            Console.Write("Введите числа: ");
            string input = Console.ReadLine();
            string[] newinput = input.Split(' '); 
            // Пробуем преобразовать введенную строку в число
            foreach (var number in newinput)
            {
                numbers.Add(Convert.ToDouble(number));
            }
            // Преобразуем список в массив и возвращаем его
            return numbers.ToArray();

        }
    }
}
