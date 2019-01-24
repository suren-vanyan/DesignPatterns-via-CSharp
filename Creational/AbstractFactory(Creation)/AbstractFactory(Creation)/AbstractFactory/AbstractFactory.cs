using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
        public abstract AbstractCover CreateCover();
    }

}
