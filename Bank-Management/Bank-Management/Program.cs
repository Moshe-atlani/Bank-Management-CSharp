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
                if (choice == 0)
                {
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your balance: ");
                    double balance = double.Parse(Console.ReadLine());
                    bank.OpenAccount(name, id, balance);
                }
                else if(choice == 1)
                {
                    Console.WriteLine();
                    bank.DisplayAll();
                }
                else if(choice == 2)
                {

                }
                else if(choice == 3)
                {

                }
                else if(choice == 4)
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
