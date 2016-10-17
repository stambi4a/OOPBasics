namespace System_Split.InputOutputManager
{
    using System;

    public class OutputWriter
    {
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
