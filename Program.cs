using System;
using System.Collections.Generic;
using System.Globalization;
using Projeto_Tag_dos_Produtos.Entities;

namespace Projeto_Tag_dos_Produtos {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Product # "+(i+1)+ " data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CI);

                if (type == 'c'){
                   Product product = new Product(name,price);
                    list.Add(product); 
                }else if (type == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");

                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    UsedProduct product = new UsedProduct(name, price ,manufactureDate );
                    list.Add(product);
                }else {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CI);

                    ImportedProduct product = new ImportedProduct(name, price ,customsFee );
                    list.Add(product);
                }

                

            }
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product p in list) {
                Console.WriteLine(p.PriceTag());

            }




        }
    }
}
