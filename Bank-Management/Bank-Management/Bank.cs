using System;

namespace Bank_Management
{
    public class Bank
    {
        private Node<Client> clientsList;
        private Node<Client> last;


        public Bank()
        {
            clientsList = null;
            last = null;
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

        public void OpenAccount(string name, int id, double balance)//ont n ai bon BH
        {

            if (clientsList == null)
            {
                Client cl = new Client(name, id, balance);
                clientsList = new Node<Client>(cl);
                last = clientsList;
            }
            else
            {
                Client cl = new Client(name, id, balance);
                last.SetNext(new Node<Client>(cl));
                last = last.GetNext();
            }
        }

        public void DisplayAll()//ont est bon BH
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

        public void SearchByAccount(int id)//ont est bom BH
        {

            Node<Client> curr = clientsList;
            
            while (curr != null)
            {
                if (curr.GetValue().GetId() == id)
                {
                    Console.WriteLine(curr.GetValue());
                    return;
                }
                else
                {
                    curr = curr.GetNext();
                }
            }
            Console.WriteLine("Search Failed..Account Not Exist.. ");
        }

        public void Deposit(int id, double amount)//ont est bom BH
        {
            Node<Client> curr = clientsList;

            while (curr != null)
            {
                if (curr.GetValue().GetId() == id)
                {
                    curr.GetValue().AddAmount(amount);
                    return;
                }
                else
                {
                    curr = curr.GetNext();
                }
            }
            Console.WriteLine("Search Failed..Account Not Exist.. ");
        }

        public void Withdrawal(int id, double amount)
        {
            Node<Client> curr = clientsList;

            while (curr != null)
            {
                if (curr.GetValue().GetId() == id)
                {
                    curr.GetValue().WithdrawalAmount(amount);
                    return;
                }
                else
                {
                    curr = curr.GetNext();
                }
            }
            Console.WriteLine("Search Failed..Account Not Exist.. ");
        }

    }
}