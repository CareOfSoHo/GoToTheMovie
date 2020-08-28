using System;
using System.Collections.Generic;

namespace GoToTheMovie
{
    public class Ticket
    {
        private List<TicketPrice> ticketList;
        public Ticket()
        {
            ticketList = new List<TicketPrice>();
        }

        public void Menu()
        {
            bool running = true;

            while (running)
            {
                int choice = GetMenuChoice();

                switch (choice)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        BuyMovieTicket();
                        break;
                    case 2:
                        BuyMovieTickets();
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("\n Felaktig input - Välj en siffra, 0 eller 1");
                        break;
                }
            }

        }

        private static int GetMenuChoice()
        {

            Console.WriteLine("\nHuvudmeny.");

            Console.WriteLine("\n\t[1] Köpa en biljett ");
            Console.WriteLine("\n\t[2] Köpa flera biljetter");
            Console.WriteLine("\n\t[0] Avsluta programmet");

            Console.WriteLine("\n\t skriv ditt val nu ");

            int menuVal;
            int.TryParse(Console.ReadLine(), out menuVal);

            return menuVal;
        }

        public void BuyMovieTickets()
        {

            Console.WriteLine("Ange antal biljetter");
            int noTickets;
            int.TryParse(Console.ReadLine(), out noTickets);

            bool run = true;

            while (run)
            {

                for (int x = 1; x <= noTickets; x++)
                {
                    Console.WriteLine("\n" + x);
                    BuyMovieTicket();

                }
                ListAllTickets();

                run = false;
            }
        }

        public void BuyMovieTicket()
        {

            Console.WriteLine("Ange din ålder");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            int price = 0;
            if (age < 20)
            {
                price = 80;
                Console.WriteLine("\n Ungdomspris " + price + "kr");

            }
            else if (age >= 65)
            {
                price = 90;
                Console.WriteLine("Pensinärspris " + price + "kr");
            }
            else
            {
                price = 120;
                Console.WriteLine("Standardpris " + price + "kr");
            }


            bool run = true;

            while (run)
            {
                TicketPrice ticketPrice = new TicketPrice(price);
                ticketList.Add(ticketPrice);

                break;
            }

        }
        private void ListAllTickets()
        {
            if (ticketList.Count <= 0)
            {
                Console.WriteLine("Inga okade biljetter");
            }
            else
            {
                int noofTickets = ticketList.Count;
                int sum = 0;
                int x = 0;
                Console.WriteLine(" Antal Bokade Biljetter: " + noofTickets);
                foreach (TicketPrice item in ticketList)
                {
                    x++;
                    Console.WriteLine("\n\t********************");
                    Console.WriteLine("\n\t Pris för biljett nr " + x + ", " + item.thePrice + "kr ");
                    sum += item.thePrice;
                }
                Console.WriteLine("\n\t Total summa för biljetterna: " + sum);
            }
        }

    }
}
