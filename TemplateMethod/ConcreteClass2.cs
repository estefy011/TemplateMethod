using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 dice: Operación Implementada1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2 dice: Operación Implementada2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2 dice: Overridden Hook1");
        }
    }
}