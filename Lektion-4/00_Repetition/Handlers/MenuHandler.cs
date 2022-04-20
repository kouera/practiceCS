using _00_Repetition.Helpers;
using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _00_Repetition.Handlers
{
    internal class MenuHandler
    {
        /// <summary>
        /// Prints out the main menu in the console
        /// </summary>
        /// <returns></returns> The selected menu value between 0-4
        public static int Menu()
        {           
            
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine("¤¤¤¤¤¤   MENU OPTION    ¤¤¤¤¤¤");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Create Particpant");
            Console.WriteLine("2. Remove Participant");
            Console.WriteLine("3. Show all Particiapnts");
            Console.WriteLine("0. Quit the Application");
            Console.WriteLine("");
            Console.Write("Select an option(0-3):  ");
            return int.Parse(Console.ReadLine()?? "-1");
            
        }

        public static void MenuOption_Create()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------- CREATE PARTICIPANT --------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            var participant = new Participant();

            Console.Write("First Name: ");
            participant.FirstName = Console.ReadLine() ??"";

            Console.Write("Last Name: ");
            participant.LastName = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            participant.Email = Console.ReadLine() ?? "";

            ParticipantHandler.AddParticipantToList(participant);

            Console.WriteLine($"\nParticpant {participant.FullName} was added to participant list");

            Task.Delay(2000).Wait();


        }

        public static void MenuOption_Remove()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------- REMOVE PARTICIPANT --------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.Write("Enter the ID for the participant to delete: ");
            ParticipantHandler.RemoveParticipantFromList(Console.ReadLine());

            Task.Delay(2000).Wait();

        }


        public static void MenuOption_List()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("-------- PARTICIPANT LIST ----------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        
    }
}
