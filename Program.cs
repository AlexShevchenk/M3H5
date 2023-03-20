using System;

namespace M3H5
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            var hellloWorld = AsyncReadFile.Concat("Hello.txt", "World.txt");
            Console.WriteLine(hellloWorld.Result);
        }


    }
}