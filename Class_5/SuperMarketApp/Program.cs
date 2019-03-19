using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person damjan = new Person()
            {
                FirstName = "Damjan",
                LastName = "Stojanovski",
                dateOfBirth = new DateTime(1992, 3, 20),
                loyalCard = true,
                buyer = true,
                cashier = false
            };

            Person Igor = new Person()
            {
                FirstName = "Igor",
                LastName = "Mitevski",
                dateOfBirth = new DateTime(1987, 2, 16),
                loyalCard = false,
                buyer = false,
                cashier = true
            };

            Product salami = new Product()
            {
                Name = "Salami",
                SN = "234yr4535323",
                Declaration = "tyrteg454645",
                Discription = "Meat product",
                Price = 100
            };

            Product kefir = new Product()
            {
                Name = "Kefir",
                SN = "234yr4535323",
                Declaration = "tyrteg454645",
                Discription = "Milk product",
                Price = 50
            };

            Product bread = new Product()
            {
                Name = "Bread",
                SN = "234yr4535323",
                Declaration = "tyrteg454645",
                Discription = "Flower based prdocut",
                Price = 30
            };

            Product cheese = new Product()
            {
                Name = "Cheese",
                SN = "64hg56wfgj",
                Discription = "Milk make product",
                Declaration = "r459wfgi4h",
                Price = 200
            };

            Cart myCart = new Cart()
            {
                SN = "123224gfd",
                products = new List<Product>()
            };
            List<Product> myProducts = new List<Product>()
            {
                bread,
                cheese,
                kefir,
                salami
            };


            damjan.Itroduction();
            Igor.Itroduction();
            // show the products with caling a method
            showProducts(myProducts);
            Console.WriteLine("Please chose y for entering a new product or press any botton if you want to exit");
            string choise = Console.ReadLine();
            if (choise == "y")
            {
                addProductToCart(myProducts);
                showProducts(myProducts);
            } 
            else
            {
                cashOut(myProducts);
                Console.WriteLine("exit");
            }
            Console.Read();
        } 
        static List<Product> addProductToCart(List<Product> myProducts)
        {
            bool valid = true;
            while(valid) { 
                Console.WriteLine("Please enter the products name");
                string productName = Console.ReadLine();
                Console.WriteLine("Pleae enter SN");
                string productSN = Console.ReadLine();
                Console.WriteLine("Please enter declaration");
                string newDeclaration = Console.ReadLine();
                Console.WriteLine("Please enter discription");
                string newDescription = Console.ReadLine();
                Console.WriteLine("Pleaes enter price");
                int price = Convert.ToInt32(Console.ReadLine());
                myProducts.Add(new Product
                {
                    Name = productName,
                    SN = productSN,
                    Declaration = newDeclaration,
                    Discription = newDescription
                });
                Console.WriteLine($"The product {productName} with the SN {productSN} with price {price} has been added to the cart");
                Console.WriteLine("Please choose y if you want to input an other product");
                string newChoise = Console.ReadLine();
                if (newChoise == "y")
                {
                    continue;
                }
                else
                {
                    valid = false;
                    break;
                }
            }
            return myProducts;
        }
        
        static void showProducts(List<Product> products)
        {
            Console.WriteLine("You have the following products in your cart so far!");
            foreach (Product item in products)
            {
                Console.WriteLine($"Product Name: {item.Name}, Product SN: {item.SN}, Product declaration: {item.Declaration}, Product Discription: {item.Discription} Price: {item.Price}");
            }
            Console.WriteLine("Would you like to cash out?");
            string choiseCashOut = Console.ReadLine();
            if (choiseCashOut == "y")
            {
                cashOut(products);
            }
            else
            {
                addProductToCart(products);
            }
        }

        static void cashOut(List<Product> produkti)
        {
            int sumToPay = 0;
            foreach (Product item in produkti)
            {
                sumToPay += item.Price;
            }
            Console.WriteLine("Total amount to pay is " + sumToPay);
        }
      } 
   }

