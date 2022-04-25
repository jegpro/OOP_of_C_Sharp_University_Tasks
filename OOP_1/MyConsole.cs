using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    class MyConsole
    {
        public static void StartCyrillic()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);
        }
        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
