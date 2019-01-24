using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        private AbstractBottle _bottle;
        private AbstractWater _water;
        private AbstractCover _cover;

        public Client(AbstractFactory factory)
        {
            _water = factory.CreateWater();
            _bottle = factory.CreateBottle();
            _cover = factory.CreateCover();
        }

        public void Run()
        {
            _bottle.Iteract(_water);
        }
    }
}
