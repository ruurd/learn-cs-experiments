using System;

namespace HelloWorld
{
    public class Greeter
    {
        private string _toWho = null;
        
        public Greeter(string who)
        {
            _toWho = who;
        }
        
        public void SayHello()
        {
            if (_toWho == null) {
                _toWho = "World";
            }
            Console.WriteLine("Hello {0}!", _toWho);
        }
    }
}