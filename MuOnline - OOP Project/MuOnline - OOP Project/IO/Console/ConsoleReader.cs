namespace MuOnline.IO.ConsoleIO
{
    using System;
    using MuOnline.IO.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
            => Console.ReadLine();
    }
}