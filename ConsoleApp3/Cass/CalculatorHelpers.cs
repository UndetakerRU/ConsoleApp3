/*internal static class CalculatorHelpers
{

    public static void Cos()
    {
        Console.Write("Введите количество градусов: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        double radians = angle * Math.PI / 180;
        double result = Math.Cos(radians);
        Console.WriteLine($"Результат: {result}");
    }

    public static void Ctg()
    {
        Console.Write("Введите количество градусов: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        double radians = angle * Math.PI / 180;
        double result = 1 / Math.Tan(radians);
        Console.WriteLine($"Результат: {result}");
    }

   public static void Sin()
    {
        Console.Write("Введите количество градусов: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        double radians = angle * Math.PI / 180;
        double result = Math.Sin(radians);
        Console.WriteLine($"Результат: {result}");
    }

    public static void Tg()
    {
        Console.Write("Введите количество градусов: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        double radians = angle * Math.PI / 180;
        double result = Math.Tan(radians);
        Console.WriteLine($"Результат: {result}");
    }

    public static void Вычитание()
    {
        Console.Write("Введите уменьшаемое: ");
        double minuend = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вычитаемое: ");
        double subtrahend = Convert.ToDouble(Console.ReadLine());
        double result = minuend - subtrahend;
        Console.WriteLine($"Результат разности: {result}");
    }

    public static void Деление()
    {
        Console.Write("Введите делимое: ");
        double dividend = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите делитель: ");
        double divisor = Convert.ToDouble(Console.ReadLine());
        if (divisor == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
            return;
        }
        double result = dividend / divisor;
        Console.WriteLine($"Результат деления: {result}");
    }

    public static void Корень()
    {
        Console.Write("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Ошибка: невозможно извлечь корень из отрицательного числа.");
            return;
        }
        double result = Math.Sqrt(number);
        Console.WriteLine($"Результат: {result}");
    }

    public static void Сложение()
    {
        Console.Write("Первое слагаемое: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Второе слагаемое: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = a + b;
        Console.WriteLine($"Результат сложения: {result}");
    }

    public static void Степень()
    {
        Console.Write("Введите степень: ");
        double exponent = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(number, exponent);
        Console.WriteLine($"Результат: {result}");
    }

    public static void Умножение()
    {
        Console.Write("Первый множитель: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Второй множитель: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = a * b;
        Console.WriteLine($"Результат умножения: {result}");
    }
}*/