using System;
using System.IO;
using System.Collections.Generic;

namespace TicketingWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to create a ticket (Y/N)?");
            char choice = Console.ReadLine().ToUpper()[0];
            string file = "Tickets.csv";
            StreamWriter sw = new StreamWriter(file);
            Ticket ticket = new Ticket();

            do
            {
                Console.WriteLine("Enter a ticket number");
                ticket.ticketNumber = Console.ReadLine();

                Console.WriteLine("Enter a summary");
                ticket.ticketSummary = Console.ReadLine();

                Console.WriteLine("Enter a status");
                ticket.ticketStatus = Console.ReadLine();

                Console.WriteLine("Enter a priority");
                ticket.ticketPriority = Console.ReadLine();

                Console.WriteLine("Enter a submitter");
                ticket.ticketSubmitter = Console.ReadLine();

                Console.WriteLine("Enter an assigned to");
                ticket.ticketAssignedTo = Console.ReadLine();

                Console.WriteLine("Would you like to add a watcher (Y/N)? ");
                char addWatcher = Console.ReadLine().ToUpper()[0];
                
                do
                {
                    Console.Write("What is the name of the watcher? ");
                    
                } while (addWatcher != 'N');
                

            } while (choice != 'N');
        }
    }
}
