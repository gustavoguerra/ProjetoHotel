using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application
{
    public static class StartMenu
    {
        public static void FirstMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            LayoutContrutor.insertlinha(3, 80);
            LayoutContrutor.insertlinha(10, 80);
            LayoutContrutor.insertcoluna(10, 10);
            LayoutContrutor.insertcoluna(80, 10);
            LayoutContrutor.InsertText(15, 4, "1 - Cadastro Quarto");
            LayoutContrutor.InsertText(15, 5, "2 - Reserva de Quarto");
            LayoutContrutor.InsertText(15, 6, "3 - Listar Quartos");
            LayoutContrutor.InsertText(15, 7, "4 - Bloquear e Liberar Quarto");
            LayoutContrutor.InsertText(15, 8, "5 - Relatorio Financeiro");
            LayoutContrutor.InsertText(15, 9, "6 - Sair");
            LayoutContrutor.InsertText(15, 9, "Digite uma Opeção e Press ENTER:");
        }

        public static void MenuReserva()
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
