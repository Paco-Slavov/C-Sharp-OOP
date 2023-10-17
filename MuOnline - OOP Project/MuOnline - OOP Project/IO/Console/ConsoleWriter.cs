namespace MuOnline.IO.Console.IO
{
    using System;
    using MuOnline.IO.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }

        public void Write(string content)
        {
            Console.Write(content);
        }
    }
}