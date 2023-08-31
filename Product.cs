namespace PetShop
{
    public class Product
    {
        public Product() { }

        public Product(int id, string name, string description, double price, int quantityInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }



    }
}