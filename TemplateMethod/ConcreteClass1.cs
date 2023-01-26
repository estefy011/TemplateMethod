using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 dice: Operación Implementada1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 dice: Operación Implementada2");
        }
    }
}
