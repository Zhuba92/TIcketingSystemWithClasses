using System;
using System.IO;
using System.Collections.Generic;

namespace TicketingWithClasses
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to create a ticket (Y/N)? ");
            char choice = Console.ReadLine().ToUpper()[0];
            string file = "Tickets.csv";
            StreamWriter sw = new StreamWriter(file);
            Ticket ticket = new Ticket();

            do
            {
                Console.Write("Enter a ticket number: ");
                ticket.ticketNumber = Console.ReadLine();

                Console.Write("Enter a summary: ");
                ticket.ticketSummary = Console.ReadLine();

                Console.Write("Enter a status: ");
                ticket.ticketStatus = Console.ReadLine();

                Console.Write("Enter a priority: ");
                ticket.ticketPriority = Console.ReadLine();

                Console.Write("Enter a submitter: ");
                ticket.ticketSubmitter = Console.ReadLine();

                Console.Write("Enter an assigned to: ");
                ticket.ticketAssignedTo = Console.ReadLine();

                Console.Write("Would you like to add a watcher (Y/N)? ");
                char addWatcher = Console.ReadLine().ToUpper()[0];
                
                while (addWatcher != 'N')
                {
                    Console.Write("Enter the name of the watcher: ");
                    string addName = Console.ReadLine();
                    ticket.ticketWatchers.Add(addName);
                    Console.Write("Would you like to add another watcher (Y/N)? ");
                    addWatcher = Console.ReadLine().ToUpper()[0];

                } 

                sw.WriteLine(ticket.Display());
                sw.Close();
                Console.Write("Would you like to create another ticket (Y/N)? ");
                choice = Console.ReadLine().ToUpper()[0];

            } while (choice != 'N');
        }
    }
}
