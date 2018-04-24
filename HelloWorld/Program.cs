using System;
using System.Runtime.InteropServices.ComTypes;

namespace HelloWorld
{
    class Program
    {
        private Greeter greeter;

        public Program()
        {
            greeter = new Greeter();
        }

        public void Run()
        {
            greeter.SayHello();
            greeter.SayHello("Ruurd");
        }

        public static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}
