using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private AbstractBottle bottle;
        private AbstractWater water;
        private AbstractCover cover;
        private AbstractLabel label;

        public Client(AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            label = factory.CreateLabel();
            cover = factory.CreateCover();
        }

        public void Run()
        {
            bottle.Interact(water);
            cover.Interact(bottle);
            label.Interact(bottle);
        }
    }
}
