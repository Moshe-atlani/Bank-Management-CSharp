namespace Bank_Management
{
    public class Client
    {
        public string name;
        public  int id;
        public double balance;

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

        //public GetName

    }
}