using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Cass
{
    public abstract class Operations
    {
        public Operations(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract double Run(double[] numbers);
    }

    public class CosOperations : Operations

    {
        public CosOperations() : base("Косинус")
        {

        }
        public override double Run(double[] numbers)
        {
            return Math.Cos(numbers[0]);

        }
    }
    public class CtgOperations : Operations
    {
        public CtgOperations() : base("Катангенс")
        {

        }
        public override double Run(double[] numbers)
        {
            return 1/Math.Tan(numbers[0]);

        }
    }
    public class SinOperations : Operations
    {
        public SinOperations() : base("Синус")
        {

        }
        public override double Run(double[] numbers)
        {
            return Math.Sin(numbers[0]);

        }
    } 
    public class TgOperations : Operations
    {
        public TgOperations() : base("Тангенс")
        {

        }
        public override double Run(double[] numbers)
        {
            return Math.Tan(numbers[0]);
        }
    }
    public class SqrtOperations : Operations
    {
        public SqrtOperations() : base("Квадратный корень")
        {

        }
        public override double Run(double[] numbers)
        {
            return Math.Sqrt(numbers[0]);
        }
    }
    public class DegreeOperations : Operations
    {
        public DegreeOperations() : base("Степень")
        {

        }
        public override double Run(double[] numbers)
        {
            return Math.Pow(numbers[0],2);
        }
    }
    public class  SubOperations : Operations
    {

        public SubOperations() : base("Вычитание")
        {

        }

        public override double Run(double[] numbers)
        {
            return (numbers[0] - numbers[1]);
        }
    }
    public class AddOperations : Operations
    {
        public AddOperations() : base("Сложение")
        {

        }

        public override double Run(double[] numbers)
        {
            return (numbers[0] + numbers[1]);
        }
    }
    public class DivOperations : Operations
    {
        public DivOperations() : base("Деление")
        {

        }
        public override double Run(double[] numbers)
        {
            return (numbers[0] / numbers[1]);
        }
    }
    public class MultOperations : Operations
    {
        public MultOperations() : base("Умножение")
        {

        }
        public override double Run(double[] numbers)
        {
            return (numbers[0] * numbers[1]);
        }
    }
}