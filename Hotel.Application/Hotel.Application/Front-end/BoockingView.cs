using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Front_end
{
    class BoockingView 
    {
        public void CreateBoking()
        {

            Console.Clear();
            LayoutContrutor.insertlinha(3, 80);
            LayoutContrutor.insertlinha(10, 80);
            LayoutContrutor.insertcoluna(10, 10);
            LayoutContrutor.insertcoluna(80, 10);
            LayoutContrutor.InsertText(15, 4, "Nome do Hospedi:");
            Console.SetCursorPosition(32, 4);
            string tipo = Console.ReadLine();
            LayoutContrutor.InsertText(15, 5, "Tipo do Quarto:");
            Console.SetCursorPosition(32, 5);
            string qnt = Console.ReadLine();
        }
    }
}
