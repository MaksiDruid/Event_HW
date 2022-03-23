using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var klava = new Keyboard();
            klava.OnKeyPressed += (sender, key) => Console.WriteLine("\n" + key + " - это не 'c'");
            klava.Press();
        }
    }
    class Keyboard
    {
        public event EventHandler<char> OnKeyPressed;
        public void Press()
        {
            char key = Console.ReadKey().KeyChar;
            while (key != 'c' && key != 'с')
            {
                OnKeyPressed?.Invoke(this, key);
                key = Console.ReadKey().KeyChar;
            }
        }
    }
}
