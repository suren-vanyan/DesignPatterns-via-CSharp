using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new CocaColaFactory());
            client.Run();

            Client client2 = new Client(new PepsiFactory());
            client2.Run();
        }
    }
}
