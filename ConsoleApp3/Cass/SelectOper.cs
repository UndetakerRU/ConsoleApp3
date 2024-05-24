using System;

namespace ConsoleApp3.Cass
{
    public interface IChooseOperation 
    {
        public Operations returnOperation(Operations operations);
    }
    public class ChooseOperation : IChooseOperation
    {//JUST DO IT

        public Operations returnOperation(Operations operations)
        {
            Console.WriteLine("Выберите действие");
            return operations [Convert.ToInt32(Console.ReadLine()) - 1];
        }
    }
}// я смотрю на небо вижу облака, так мало дней но я ею обладал. Пролетел инопланетный бла бла кар но она была со мной она была...