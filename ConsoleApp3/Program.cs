using ConsoleApp3.Cass;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в Бойцовский клуб");

        while (true)
        {
            Console.WriteLine("\nГлавное меню:");
            Console.WriteLine("1. Сложение(+)");
            Console.WriteLine("2. Вычитание(-)");
            Console.WriteLine("3. Деление(/)");
            Console.WriteLine("4. Умножение(*)");
            Console.WriteLine("5. Степень(sqr)");
            Console.WriteLine("6. Корень(sqrt)");
            Console.WriteLine("7. Синус(sin)");
            Console.WriteLine("8. Косинус(cos)");
            Console.WriteLine("9. Тангенс(tg)");
            Console.WriteLine("10. Котангенс(ctg)");
            Console.WriteLine("11. Выход из консоли(end)");
            Console.WriteLine("Выберите пункт:");

            string choice = Console.ReadLine().ToLower();

            /* switch (choice)
             {
                 case "1":
                     CalculatorHelpers.Сложение();
                     break;
                 case "2":
                     CalculatorHelpers.Вычитание();
                     break;
                 case "3":
                     CalculatorHelpers.Деление();
                     break;
                 case "4":
                     CalculatorHelpers.Умножение();
                     break;
                 case "5":
                     CalculatorHelpers.Степень();
                     break;
                 case "6":
                     CalculatorHelpers.Корень();
                     break;
                 case "7":
                     CalculatorHelpers.Sin();
                     break;
                 case "8":
                     CalculatorHelpers.Cos();
                     break;
                 case "9":
                     CalculatorHelpers.Tg();
                     break;
                 case "10":
                     CalculatorHelpers.Ctg();
                     continue;
                 case "11":
                     return;
                 default:
                     Console.WriteLine("Некорректный ввод.");
                     break;
             }*/
            Case caser = new Case();
            caser.Choice(Convert.ToInt32(choice));
        }
    }
}