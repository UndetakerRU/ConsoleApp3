using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Cass;

namespace ConsoleApp3.Cass

{
    public interface IMenu<out T>
    {
        public IMenu<T> Show();
        
    }
}