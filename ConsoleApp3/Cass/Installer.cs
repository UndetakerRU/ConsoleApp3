using Calculator.Menues;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.Startable;
using ConsoleApp3.Cass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3.Cass
{
    public class LocalInstaller : IWindsorInstaller
    {

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<App>()
                         .StartUsingMethod("Run"),

                Component.For<IMenu<IOperations>>()
                         .ImplementedBy<Menu>()// i want to fix this
                         .LifestyleTransient(),
                Component.For<IOperationProvider>()
                         .ImplementedBy<OperationProvider>(),

                Component.For<Operations>()
                         .ImplementedBy<AddOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<SubOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<MultOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<DivOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<DegreeOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<SqrtOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<TgOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<SinOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<CtgOperations>(),
                Component.For<Operations>()
                         .ImplementedBy<CosOperations>()
                
            );

        }
    }
}