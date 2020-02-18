using System;

namespace TicketApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ticket Order in C#\r");
            Console.WriteLine("------------------------\n");
            get_choice();
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
        static void get_choice()
        {
            Console.WriteLine("Type of Ticket\n");
            Console.WriteLine("1. Standaarth'\n" +
            "2. Student\n" +
            "3. 65+\n" +
            "4. Kids\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Normal");
                    break;
                case 2:
                    Console.WriteLine("Student");
                    break;
                case 3:
                    Console.WriteLine("65+");
                    break;
                case 4:
                    Console.WriteLine("Kids");
                    break;
                default:
                    Console.WriteLine("geen geldige keuze probeer het opnieuw!");
                    get_choice();
                    break;
            }
        }
    }
}
