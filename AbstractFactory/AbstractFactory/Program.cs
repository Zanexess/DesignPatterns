using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            Client client = null;

            client = new Client(new CocaCollaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();

            client = new Client(new SchweppesFactory());
            client.Run();
        }
    }
}

