using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass dice: Estoy haciendo la mayor parte del trabajo");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass dice: Pero dejo que las subclases anulen algunas operacioneS");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass dice: Pero estoy haciendo la mayor parte del trabajo de todos modos");
        }

        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
