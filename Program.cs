// Sistema para controle de Produtos de um Petshop
using System.Globalization;
using PetShop;

var menu = new Menu();
List<Client> clientsList = new List<Client>();
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
            Console.WriteLine("==========================");
            Console.WriteLine("== CADASTRO DE PRODUTOS ==");
            Console.WriteLine("==========================");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Descrição: ");
            string description = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantityInStock = int.Parse(Console.ReadLine());
            productsList.Add(new Product(id, name, description, price, quantityInStock));
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("=======================");
            Console.WriteLine("== BUSCA DE PRODUTOS ==");
            Console.WriteLine("=======================");
            if (productsList.Count == 0)
            {
                Console.WriteLine("Não existem produtos cadastrados");
            }
            else
            {


                Console.Write("Insira o ID do produto que deseja buscar: ");
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
                    Console.WriteLine("O produto aparentemente não está cadastrado no sistema.");
                }
                else
                {
                    Console.WriteLine($"{productFound.Id}: {productFound.Name}, preço: R$ {productFound.Price.ToString("F2", CultureInfo.InvariantCulture)}, estoque: {productFound.QuantityInStock}");
                }
            }
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("== DELETAR PRODUTO ==");
            Console.WriteLine("=====================");
            if (productsList.Count == 0)
            {
                Console.WriteLine("Não existem produtos cadastrados");
            }
            else
            {
                Console.Write("Insira o ID do produto que deseja deletar: ");
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
                    Console.WriteLine("O produto aparentemente não está cadastrado no sistema.");
                }
                else
                {
                    productsList.Remove(productFound);
                    Console.WriteLine($"Produto {productFound.Name} ({productFound.Id}) excluído");
                }
            }

            break;
        case 4:
            Console.Clear();
            Console.WriteLine("=============");
            Console.WriteLine("== ESTOQUE ==");
            Console.WriteLine("=============");
            if (productsList.Count == 0)
            {
                Console.WriteLine("Não existem produtos cadastrados");
            }
            else
            {
                foreach (Product productInList in productsList)
                {
                    Console.WriteLine($"{productInList.Id}: {productInList.Name}, preço ${productInList.Price}, quantidade: {productInList.QuantityInStock}");
                }
            }

            break;

        case 5:
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("== CADASTRO DE CLIENTE ==");
            Console.WriteLine("=========================");
            Console.Write("ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            clientsList.Add(new Client(id, name, cpf));
            break;

        case 6:
            Console.Clear();
            Console.WriteLine("======================");
            Console.WriteLine("== BUSCA DE CLIENTE ==");
            Console.WriteLine("======================");
            if (clientsList.Count == 0)
            {
                System.Console.WriteLine("Não há clientes cadastrados no sistema.");
            }
            else
            {
                Client clientSearch = new Client();
                clientSearch.Id = -1;
                System.Console.Write("Insira o ID do cliente que deseja buscar: ");
                int idSearch = int.Parse(Console.ReadLine());
                foreach (Client client in clientsList)
                {
                    if (client.Id == idSearch)
                    {
                        clientSearch = client;
                    }
                }
                if (clientSearch.Id == -1)
                {
                    System.Console.WriteLine("Usuário não está cadastrado em nosso sistema.");
                }
                else
                {
                    System.Console.WriteLine($"{clientSearch.Id}: {clientSearch.Name} - {clientSearch.Cpf} ");
                }
            }
            break;

        case 0:
            Console.WriteLine("Obrigado por usar nosso sistema!");
            stopLoop = true;
            break;

    }
    Console.WriteLine("Pressione qualquer tecla para seguir...");
    Console.ReadKey();

}
