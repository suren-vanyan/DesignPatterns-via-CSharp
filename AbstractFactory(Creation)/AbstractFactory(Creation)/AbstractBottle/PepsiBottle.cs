using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PepsiBottle : AbstractBottle
    {
        public override void Iteract(AbstractWater water)
        {
            Console.WriteLine($"{this} iteract with {water}");
        }
    }
}
