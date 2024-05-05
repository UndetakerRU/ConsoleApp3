using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Cass
{
    public abstract class Operations
    {
        public abstract double Run(double[] numbers);
    }

    public class CosOperations : Operations

    {
        public override double Run(double[] numbers)
        {
            return Math.Cos(numbers[0]);

        }
    }
    public class CtgOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return 1/Math.Tan(numbers[0]);

        }
    }
    public class SinOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return Math.Sin(numbers[0]);

        }
    } 
    public class TgOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return Math.Tan(numbers[0]);
        }
    }
    public class SqrtOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return Math.Sqrt(numbers[0]);
        }
    }
    public class DegreeOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return Math.Pow(numbers[0],2);
        }
    }
    public class  SubOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return (numbers[0] - numbers[1]);
        }
    }
    public class AddOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return (numbers[0] + numbers[1]);
        }
    }
    public class DivOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return (numbers[0] / numbers[1]);
        }
    }
    public class MultOperations : Operations
    {
        public override double Run(double[] numbers)
        {
            return (numbers[0] * numbers[1]);
        }
    }
}