using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();

        }
    }
}
