using Hotel.Application.Front_end;
using System;

namespace Hotel.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu.FirstMenu();
            var room = new RoomView();

            Console.SetCursorPosition(48, 9);
            string valor = Console.ReadLine();

            if (valor == "1")
                room.CreateRoom();
            if (valor == "2")
                StartMenu.MenuReserva();

        }
    }
}
