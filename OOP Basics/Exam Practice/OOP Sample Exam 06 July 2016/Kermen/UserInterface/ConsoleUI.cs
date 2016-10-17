namespace Kermen.UserInterface
{
    using System;

    using Interfaces;

    public class ConsoleUi : IUserInterface
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string result)
        {
            Console.Write(result);
        }

        public void WriteLine(string result)
        {
            Console.WriteLine(result);
        }

        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
