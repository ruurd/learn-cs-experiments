using System;
using System.Runtime.InteropServices.ComTypes;

namespace HelloWorld
{
    class Program
    {
        private readonly Greeter _greeter;

        public Program()
        {
            _greeter = new Greeter("Ruurd");
        }

        public void Run()
        {
            _greeter.SayHello();
        }

        public static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}
