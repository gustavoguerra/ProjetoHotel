using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hotel.Application
{
    public static class LayoutContrutor
    {
        public static void InsertText(int col, int lin, string txt)
        {
            Console.SetCursorPosition(col, lin);
            Console.WriteLine(txt);
        }

        public static void insertlinha(int start, int qnt)
        {
            for (int i = 10; i <= qnt; i++)
            {
                Thread.Sleep(2);
                Console.SetCursorPosition(i, start);
                Console.WriteLine("*");
            }
        }
        public static void insertcoluna(int start, int qnt)
        {
            for (int i = 3; i <= qnt; i++)
            {
                Thread.Sleep(2);
                Console.SetCursorPosition(start, i);
                Console.WriteLine("*");
            }
        }

    }
}
