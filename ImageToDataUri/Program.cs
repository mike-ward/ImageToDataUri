using System;
using System.IO;

namespace ImageToDataUri
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Error.WriteLine("usage: ImageToDataUri <file> <format>");
                return 1;
            }

            var dataUri = $"data:image/{args[1]};base64,"
                          + Convert.ToBase64String(File.ReadAllBytes(args[0]));

            Console.Write(dataUri);
            return 0;
        }
    }
}