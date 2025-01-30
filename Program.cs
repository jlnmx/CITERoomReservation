using System;
using System.Collections.Generic;
using CITERoomReservationForm;
using CITERoomReserveLogic;

namespace room_reservation
{
    internal class Program
    {
        static string[] actions = new[]
        {
                "Type 'register' to register an account.",
                "Type 'login' to login to your account.",
                "Type 'add' to fill up information.",
                "Type 'reserve' to reserve a room or laboratory.",
                "Type 'view' to view all reservations.",
                "Type 'delete' to delete a reservation.",
                "Type 'exit' if you want to exit."
            };

        //static List<string> username = new List<string>();
        //static List<string> password = new List<string>();
        //static List<string> names = new List<string>();
        //static List<string> courses = new List<string>();
        //static List<string> sections = new List<string>();
        //static List<string> professors = new List<string>();
        //static List<string> reservations = new List<string>();

        //static List<string> availableRooms = new List<string>
        //    {
        //        "Room 203",
        //        "Room 204",
        //        "Room 205",
        //        "Room 206",
        //        "Room 207",
        //        "Room 208"
        //    };

        //static List<string> availableSchedules = new List<string>
        //    {
        //        "2023-10-25 14:00",
        //        "2023-10-25 16:00",
        //        "2023-10-26 10:00",
        //        "2023-10-26 12:00"
        //    };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PUPBC Room Reservation");
            Console.WriteLine();
            Console.WriteLine("Type the action that you want to perform...");

            DisplayActions();
            Console.WriteLine();

            Console.Write("Type action: ");
            string userAction = Console.ReadLine();

            while (userAction.ToLower() != "exit")
            {
                switch (userAction.ToLower())
                {
                    case "register":
                        AdminRegister();
                        break;

                    case "login":
                        AdminLogin();
                        break;

                    case "add":
                        AddInfo();
                        break;

                    case "reserve":
                        ReserveRoom();
                        break;

                    case "view":
                        ViewReservations();
                        break;

                    case "delete":
                        DeleteReservation();
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        break;
                }

                Console.WriteLine();
                DisplayActions();
                Console.WriteLine();
                Console.Write("Type action: ");
                userAction = Console.ReadLine();
            }

            Console.WriteLine("Thank You!");
        }

        static void DisplayActions()
        {
            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
        }

        static void AdminRegister()
        {
            Console.WriteLine("REGISTER AN ACCOUNT");
            Console.WriteLine();

            Console.Write("Enter Username: ");
            string enterUsername = Console.ReadLine();
            Console.Write("Enter Password: ");
            string enterPassword = Console.ReadLine();

            CITERoomReserve.AdminRegister(enterUsername, enterPassword);

            Console.WriteLine("Successfully registered account: " + enterUsername);
        }

        

        static void AdminLogin()
        {
            Console.WriteLine("LOGIN TO YOUR ACCOUNT");
            Console.Write("Enter Username: ");
            string inputUsername = Console.ReadLine();
            Console.Write("Enter Password: ");
            string inputPassword = Console.ReadLine();
            CITERoomReserve.AdminLogin(inputUsername, inputPassword);
        }
  

        static void AddInfo()
        {
            Console.WriteLine("FILL UP INFORMATION");
            Console.WriteLine();

            Console.Write("Enter Name: ");
            string enterName = Console.ReadLine();
            Console.Write("Enter Course: ");
            string enterCourse = Console.ReadLine();
            Console.Write("Enter Section: ");
            string enterSection = Console.ReadLine();
            Console.Write("Enter Name of Professor (optional): ");
            string enterProfessor = Console.ReadLine();

            CITERoomReserve.AddInfo(enterName, enterCourse, enterSection, enterProfessor);

            Console.WriteLine("Successfully added user: " + enterName);
        }

        static void ReserveRoom()
        {
            Console.WriteLine("RESERVE A ROOM OR LABORATORY");

            Console.WriteLine("Available Rooms:");
            var availableRooms = CITERoomReserve.GetAvailableRooms();
            foreach (var room in availableRooms)
            {
                Console.WriteLine("- " + room);
            }

            string roomOrLab;
            do
            {
                Console.Write("Enter the name of the room or laboratory: ");
                roomOrLab = Console.ReadLine();
                if (!availableRooms.Contains(roomOrLab))
                {
                    Console.WriteLine("Invalid room or laboratory. Please choose from the available rooms.");
                }
            } while (!availableRooms.Contains(roomOrLab));

            Console.WriteLine("Available Schedules:");
            var availableSchedules = CITERoomReserve.GetAvailableSchedules();
            foreach (var schedule in availableSchedules)
            {
                Console.WriteLine("- " + schedule);
            }

            string dateTime;
            do
            {
                Console.Write("Enter the date and time for the reservation (e.g., 2023-10-25 14:00): ");
                dateTime = Console.ReadLine();
                if (!availableSchedules.Contains(dateTime))
                {
                    Console.WriteLine("Invalid schedule. Please choose from the available schedules.");
                }
            } while (!availableSchedules.Contains(dateTime));

            CITERoomReserve.ReserveRoom(roomOrLab, dateTime);
            Console.WriteLine($"Successfully reserved: {roomOrLab} at {dateTime}");
        }

        static void ViewReservations()
        {
            Console.WriteLine("VIEW ALL RESERVATIONS");
            var reservations = CITERoomReserve.GetAllReservations();

            if (reservations.Count == 0)
            {
                Console.WriteLine("No reservations made yet.");
            }
            else
            {
                Console.WriteLine("Reservations:");
                foreach (var reservation in reservations)
                {
                    Console.WriteLine($"- {reservation}");
                }
            }
        }



        static void DeleteReservation()
        {
            Console.WriteLine("DELETE A RESERVATION");
            ViewReservations();
            var reservations = CITERoomReserve.GetAllReservations();
            if (reservations.Count == 0) return;

            Console.Write("Enter the reservation number to delete: ");
            int reservationNumber;
            if (int.TryParse(Console.ReadLine(), out reservationNumber) && reservationNumber > 0 && reservationNumber <= reservations.Count)
            {
                reservationNumber--;
                CITERoomReserve.DeleteReservation(reservationNumber);
                Console.WriteLine("Successfully deleted reservation.");
            }
            else
            {
                Console.WriteLine("Invalid reservation number.");
            }
        }
    }
}