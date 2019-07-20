using Hotel.Business;
using Hotel.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Front_end
{
    public class RoomView
    {
        public void CreateRoom()
        {
            Console.Clear();
            LayoutContrutor.insertlinha(3, 80);
            LayoutContrutor.insertlinha(10, 80);
            LayoutContrutor.insertcoluna(10, 10);
            LayoutContrutor.insertcoluna(80, 10);

            LayoutContrutor.InsertText(15, 4, "Digite Tipo Quarto:");

            LayoutContrutor.InsertText(15, 5, "Digite Quantidade de Quartos:");

            LayoutContrutor.InsertText(15, 6, "Digite o Valor da Diaria:");

            Console.SetCursorPosition(35, 4);
            string tipo = Console.ReadLine();
            Console.SetCursorPosition(45, 5);
            string qnt = Console.ReadLine();
            Console.SetCursorPosition(41, 6);
            string price = Console.ReadLine();
        }
    }
}
