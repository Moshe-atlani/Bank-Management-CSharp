using System;

namespace Bank_Management
{
    public class Bank
    {
        private Node<Client> clientsList;

        public Bank()
        {
            clientsList = null;
        }


        public void ShowMenu()
        {
            Console.WriteLine("menu");
            Console.WriteLine("0. Open Account:");
            Console.WriteLine("1. Display All");
            Console.WriteLine("2. Search By Account");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdrawal");
            Console.WriteLine("5. Exit");
        }

        public void OpenAccount(string name, int id, double balance)
        {
            if (clientsList == null)
            {
                Client cl = new Client(name, id, balance);
                clientsList = new Node<Client>(cl);
            }
            else
            {
                // moshe TODO
            }
        }

        public void DisplayAll()
        {
            if (clientsList == null)
            {
                Console.WriteLine("No clients in the bank...");
            }
            else
            {
                Node<Client> curr = clientsList;
                while (curr != null)
                {
                    Console.WriteLine(curr.GetValue());
                    curr = curr.GetNext();
                }
            }

        }

    }
}