using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    class Program
    {

        private static List<string> parties = new List<string>();

        private static int totalGuests = 0;
        static void Main(string[] args)
        {

            LoadGuests();
            DisplayGuests();
            DisplayGuestCount();
            
           
            Console.ReadLine();
        }
        
        //Ask user for the number of people the came to party with
        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;

            do
            {
                string partySizeText = GetInfoFromConsole("How many people in your party: ");

                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;

        }



        //Get info from user from the command line
        private static string GetInfoFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        //Load all the guests

        private static void LoadGuests()
        {

            string moreGuestComing = "";

            do
            {
                string partyName = GetInfoFromConsole("What is the name of your party / group: ");
                parties.Add(partyName);

                totalGuests += GetPartySize();
                Console.WriteLine();
                DisplayGuestCount();

                moreGuestComing = GetInfoFromConsole("Do you want to add another guest (yes/no): ");

            } while (moreGuestComing.ToLower() == "yes");

        }

        //Display Guest Info

        private static void DisplayGuests()
        {
            Console.WriteLine();
            Console.WriteLine("Guest Parties at Event:");

            foreach (var name in parties)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine();
           

        }

        private static void DisplayGuestCount()
        {
            Console.WriteLine($"Total Guests: { totalGuests }");
        }
    }
}
