using System;
using System.Collections.Generic;

namespace room_reservation
{
    internal class Program
    {
        static string name = string.Empty;
        static string course = string.Empty;
        static string section = string.Empty;
        static string professor = string.Empty;
        static List<string> reservations = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PUPBC Room and Laboratory Reservation");
            Console.WriteLine();
            Console.WriteLine("Type the action that you want to perform...");

            Console.WriteLine("Type 'add' To Register");
            Console.WriteLine("Type 'reserve' to reserve a room or laboratory.");
            Console.WriteLine("Type 'view_reservations' to view all reservations.");
            Console.WriteLine("Type 'exit' if you want to exit");

            Console.WriteLine();

            string userAction = string.Empty;

            while (userAction != "exit")
            {
                Console.Write("Choose an Action: ");
                userAction = Console.ReadLine().ToLower();

                switch (userAction)
                {
                    case "add":
                        AddUser();
                        break;

                    case "reserve":
                        ReserveRoom();
                        break;

                    case "view_reservations":
                        ViewReservations();
                        break;

                    default:
                        if (userAction != "exit")
                        {
                            Console.WriteLine("Invalid Input. Please try again.");
                        }
                        break;
                }

                if (userAction != "exit")
                {
                    ShowOptions();
                }
            }

            Console.WriteLine("Thank You!");
            Environment.Exit(0);
        }

        static void ShowOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Type 'add' To Register");
            Console.WriteLine("Type 'reserve' to reserve a room or laboratory.");
            Console.WriteLine("Type 'view_reservations' to view all reservations.");
            Console.WriteLine("Type 'exit' if you want to exit");
            Console.WriteLine();
        }

        static void AddUser()
        {
            Console.WriteLine("ADD USER ACCOUNT");
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Course: ");
            course = Console.ReadLine();
            Console.Write("Enter Section: ");
            section = Console.ReadLine();
            Console.Write("Enter Name of Professor (optional): ");
            professor = Console.ReadLine();
            Console.WriteLine("Successfully added user " + name);
        }

        static void ReserveRoom()
        {
            Console.WriteLine("RESERVE A ROOM OR LABORATORY");
            Console.Write("Enter the name of the room or laboratory: ");
            string roomOrLab = Console.ReadLine();
            reservations.Add(roomOrLab);
            Console.WriteLine("Successfully reserved: " + roomOrLab);
        }

        static void ViewReservations()
        {
            Console.WriteLine("VIEW ALL RESERVATIONS");
            if (reservations.Count == 0)
            {
                Console.WriteLine("No reservations made yet.");
            }
            else
            {
                Console.WriteLine("Reservations:");
                foreach (string reservation in reservations)
                {
                    Console.WriteLine("- " + reservation);
                }
            }
        }
    }
}