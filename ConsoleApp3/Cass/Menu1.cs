
using ConsoleApp3.Cass;
using System;

namespace Calculator.Menues
{
    public sealed class Menu : IMenu <IOperations> //если я сломал 5 пальцев я гуль sssss ранга???
    {
        public Menu(IOperationProvider provider)
        { 
        this.operations = provider;//РОСТЕЛЕКОМ?
        }
        IOperationProvider  operations;

        public IMenu<IOperations> Show()//тутуттуту поехала шляпа на этом моменте 
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            for (int i = 0; i < operations.Get().ToArray().Length; i++)
            {
                Console.WriteLine($"{i + 1}. ОПЕРАЦИЯ {operations.Get().ToArray()[i]};");
            }
            return this;
        }
    }
}//спустя 5 кружек кофе и пачка сигарет 