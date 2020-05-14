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
                    Console.WriteLine();
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your balance: ");
                    double balance = double.Parse(Console.ReadLine());
                    bank.OpenAccount(name, id, balance);
                    Console.WriteLine();
                }
                else if(choice == 1)
                {
                    Console.WriteLine();
                    bank.DisplayAll();
                    Console.WriteLine();
                }
                else if(choice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Account Id No U Want to Search...:");
                    int idToSearch = int.Parse(Console.ReadLine());//pb
                    bank.SearchByAccount(idToSearch);
                    Console.WriteLine();
                }
                else if(choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Account Id No :");
                    int idToDeposit = int.Parse(Console.ReadLine());
                    bank.SearchByAccount(idToDeposit);
                    Console.WriteLine("Enter Amount U Want to Deposit : ");
                    double amountToDeposit = double.Parse(Console.ReadLine());
                    bank.Deposit(idToDeposit, amountToDeposit);
                    Console.WriteLine();
                }
                else if(choice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Account Id No :");
                    int idToWithdrawal = int.Parse(Console.ReadLine());
                    bank.SearchByAccount(idToWithdrawal);
                    Console.WriteLine("Enter Amount U Want to withdraw :");
                    double amountToWithdrawal = double.Parse(Console.ReadLine());
                    bank.Withdrawal(idToWithdrawal, amountToWithdrawal);
                    Console.WriteLine();
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
