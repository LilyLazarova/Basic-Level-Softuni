using System;

    class PrintTheASCIITable
    {
        static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.ASCII;
            for (ushort asciiCodeNumber = 0; asciiCodeNumber<256;asciiCodeNumber++)
            {
                Console.WriteLine(asciiCodeNumber +"-->"+(char)asciiCodeNumber);
            }
        }
    }

