
namespace Multithreading
{
    internal class Switcher
    {
        public void Print0()
        {
            while (true)
            {
                Console.Write("0");
            }
        }

        public void Print1()
        {
            while (true)
            {
                Console.Write("1");
            }
        }

        public void Switch()
        {
            Thread thread = new Thread(Print0);
            thread.Start();
            Print1();
        }
    }
}
