using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // קוד שישתמש במחלקות שלך

            Bank bank = new Bank();
            bool exit = false;
            while(!exit)
            {
                bank.ShowMenu();
                Console.WriteLine("Please enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine();
                }
                else if(choice == 2)
                {

                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Error: Invalid choice: " + choice);
                }
            }
        }
    }
}
