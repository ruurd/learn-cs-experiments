using System;

namespace HelloWorld
{
    public class Greeter
    {
        public void SayHello(String toWho = null)
        {
            if (toWho == null) {
                toWho = "World";
            }
            Console.WriteLine("Hello {0}!", toWho);
        }
    }
}