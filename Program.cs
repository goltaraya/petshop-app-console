// Sistema para controle de Produtos de um Petshop
using System.Globalization;

var menu = new Menu();
List<Product> productsList = new List<Product>();

bool stopLoop = false;
int option = -1;

while (!stopLoop)
{
    Console.Clear();

    menu.showMenu();
    option = int.Parse(s: Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            System.Console.WriteLine("==========================");
            System.Console.WriteLine("== CADASTRO DE PRODUTOS ==");
            System.Console.WriteLine("==========================");
            System.Console.Write("ID:");
            int id = int.Parse(Console.ReadLine());
            System.Console.Write("Nome: ");
            string name = Console.ReadLine();
            System.Console.Write("Descrição: ");
            string description = Console.ReadLine();
            System.Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade em estoque: ");
            int quantityInStock = int.Parse(Console.ReadLine());
            Product product = new Product(id, name, description, price, quantityInStock);
            productsList.Add(product);
            break;

        case 2:
            Console.Clear();
            System.Console.WriteLine("=======================");
            System.Console.WriteLine("== BUSCA DE PRODUTOS ==");
            System.Console.WriteLine("=======================");
            System.Console.Write("Insira o ID do produto que deseja buscar: ");
            int idSearch = int.Parse(Console.ReadLine());

            Product productFound = new Product
            {
                Id = -1
            };

            foreach (Product productSearch in productsList)
            {
                if (productSearch.Id == idSearch)
                {
                    productFound = productSearch;
                    break;
                }
            };
            if (productFound.Id == -1)
            {
                System.Console.WriteLine("O produto aparentemente não está cadastrado no sistema.");
            }
            else
            {
                System.Console.WriteLine($"{productFound.Id}: {productFound.Name}, stock: {productFound.QuantityInStock}, price: $ {productFound.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            System.Console.WriteLine("Pressione qualquer tecla para seguir...");
            Console.ReadKey();
            break;

        case 3:
            Console.Clear();
            System.Console.WriteLine("=====================");
            System.Console.WriteLine("== DELETAR PRODUTO ==");
            System.Console.WriteLine("=====================");
            if (productsList.Count == 0)
            {
                System.Console.WriteLine("Não existem produtos cadastrados");
            }
            else
            {
                System.Console.Write("Insira o ID do produto que deseja deletar: ");
                idSearch = int.Parse(Console.ReadLine());

                productFound = new Product
                {
                    Id = -1
                };

                foreach (Product productSearch in productsList)
                {
                    if (productSearch.Id == idSearch)
                    {
                        productFound = productSearch;
                        break;
                    }
                };
                if (productFound.Id == -1)
                {
                    System.Console.WriteLine("O produto aparentemente não está cadastrado no sistema.");
                }
                else
                {
                    productsList.Remove(productFound);
                    System.Console.WriteLine($"Produto {productFound.Name} ({productFound.Id}) excluído");
                }
            }

            System.Console.WriteLine("Pressione qualquer tecla para seguir...");
            Console.ReadKey();

            break;
    }
}