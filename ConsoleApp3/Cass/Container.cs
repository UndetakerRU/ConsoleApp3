using Castle.Windsor;
using ConsoleApp3.Cass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using Calculator.Menues;

namespace ConsoleApp3.Cass
{
    public interface IOperationProvider 
    {
        public IEnumerable<Operations> Get();
    }
    public class OperationProvider : IOperationProvider
    {
        private IEnumerable<Operations> operations;
        public OperationProvider(IEnumerable<Operations> operations)
        {
            this.operations = operations;
        }
        public IEnumerable<Operations> Get()
        {
            return operations;
        }
    }
    public class App
    {
        //я смотрю аниме я очень куртой мама смотри я ......
        public App(
         IMenu<IOperations> menu)
        {
            this.menu = menu;
        }
        private IMenu<IOperations> menu;
        public void Run()
        {
          Operations operations = (Operations) menu.Show();
        }
        
    }
}