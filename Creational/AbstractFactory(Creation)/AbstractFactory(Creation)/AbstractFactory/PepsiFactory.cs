using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PepsiFactory:AbstractFactory
    {
       
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
