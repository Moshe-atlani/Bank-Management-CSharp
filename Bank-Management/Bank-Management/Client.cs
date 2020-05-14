namespace Bank_Management
{
    public class Client
    {
        private string name;
        private int id;
        private double balance;

        public int GetId() { return this.id; }
        public double GetBalance() { return this.balance; }

        public Client(string name, int id, double balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        public override string ToString()
        {
            return $"Client(name = {this.name}, id = {this.id}, balance = {this.balance})";
        }

        public void AddAmount(double amount)
        {
            this.balance += amount;
        }

        public void WithdrawalAmount(double amount)
        {
            this.balance -= amount;
        }

    }
}