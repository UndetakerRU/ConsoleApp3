using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3.Cass
{
    public class Case
    {
        public void Choice(int xyin9)
        {
            Zapros zapros = new Zapros();

            Result result = new Result();

            switch (xyin9)
            {
                case 8:
                    CosOperations cosOperations = new CosOperations();
                    result.Rezult(cosOperations.Run(zapros.GetNumbers()));
                    break;

                case 7:
                    SinOperations sinOperations = new SinOperations();
                    result.Rezult(sinOperations.Run(zapros.GetNumbers()));
                    break;
                case 10:
                    CtgOperations ctgOperations = new CtgOperations();
                    result.Rezult(ctgOperations.Run(zapros.GetNumbers()));
                    break;
                case 9:
                    TgOperations tgOperations = new TgOperations();
                    result.Rezult(tgOperations.Run(zapros.GetNumbers()));
                    break;
                case 6:
                    SqrtOperations sqrtOperations = new SqrtOperations();
                    result.Rezult(sqrtOperations.Run(zapros.GetNumbers()));
                    break;
                case 5:
                    DegreeOperations degreeOperations = new DegreeOperations();
                    result.Rezult(degreeOperations.Run(zapros.GetNumbers()));
                    break;
                case 2:
                    SubOperations subOperations = new SubOperations();
                    result.Rezult(subOperations.Run(zapros.GetNumbers()));
                    break;
                case 1:
                    AddOperations addOperations = new AddOperations();
                    result.Rezult(addOperations.Run(zapros.GetNumbers()));
                    break;
                case 3:
                    DivOperations divOperations = new DivOperations();
                    result.Rezult(divOperations.Run(zapros.GetNumbers()));
                    break;
                case 4:
                    MultOperations multOperations = new MultOperations();
                    result.Rezult(multOperations.Run(zapros.GetNumbers()));
                    break;


            }

        }

    }
}