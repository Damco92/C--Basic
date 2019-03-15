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

            Product bread = new Product()
            {
                Name = "Bread",
                SN = "234yr4535323",
                Declaration = "tyrteg454645",
                Discription = "Flower based prdocut"
            };

            Product cheese = new Product()
            {
                Name = "Cheese",
                SN = "64hg56wfgj",
                Discription = "Milk make product",
                Declaration = "r459wfgi4h"
            };

            Cart myCart = new Cart()
            {
                SN = "123224gfd",
                listOfProducts = new string[2]
            };
            Product[] myProducts = new Product[2];
            myProducts[0] = bread;
            myProducts[1] = cheese;

            damjan.Itroduction();
            Igor.Itroduction();
            bool valid = true;
            while (valid)
            {
                Console.WriteLine("Please enter product");
                string inputProduct = Console.ReadLine();
                int counter = 0;
                foreach (Product product in myProducts)
                {
                   if (inputProduct == product.Name)
                    {
                        Console.WriteLine($"The product {product.Name} has been entered in the list");
                        Array.Resize<string>(ref myCart.listOfProducts, myCart.listOfProducts.Length + 1);
                        inputProduct = myCart.listOfProducts[counter];
                        counter++;

                    }
                    else if (inputProduct != product.Name)
                    {
                        Console.WriteLine("There is no such product available. Pleae try again");
                        break;
                    }
                }
            }

          } 
        } 
    }

