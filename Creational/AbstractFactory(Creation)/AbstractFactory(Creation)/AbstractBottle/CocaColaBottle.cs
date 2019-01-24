using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Iteract(AbstractWater water)
        {
            Console.WriteLine($"{this} INTERACT WITH {water}");
        }
    }
}
