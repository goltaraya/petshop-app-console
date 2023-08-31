namespace PetShop
{
    public class Client
    {
        public Client() { }
        public Client(int id, string name, string cpf)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
    }
}