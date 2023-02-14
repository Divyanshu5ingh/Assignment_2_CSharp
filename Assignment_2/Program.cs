using System;
using System.Collections.Generic;

namespace Assignment_2
{  
    class Program
    {
        static void Main(string[] args)
        {
            var product = new List<Product>
            {
                new Product("Lettuce", 10.5, 50, "Leafy green"),
                new Product("Cabbage", 20, 100, "Cruciferous"),
                new Product("pumpkin", 30, 30, "Marrow"),
                new Product("cauliflower", 10, 25, "Cruciferous"),
                new Product("zucchini", 20.5, 50, "Marrow"),
                new Product("yam", 30, 50, "Root"),
                new Product("spinach", 10, 100, "Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("garlic", 30, 20, "Leafy green"),
                new Product("silverbeet", 10, 50, "Marrow")
            };
            //1. To print the total number of product
            Console.WriteLine("Total number of products in the list = {0}\n", product.Count);

            //2. Adding a new product and printing total number of product now
            product.Add(new Product("Potato", 10, 50, "Root"));
            foreach (var listOfproduct in product)
            {
                Console.WriteLine(listOfproduct.Name + "\t" + listOfproduct.Price + "RS" + "\t" + listOfproduct.Quantity + "\t" + listOfproduct.Type);
            }
            Console.WriteLine("Total number of updated products in the list = {0}", product.Count);
            
            //3. Printing all the product which have type == "Leafy green"
            Console.WriteLine("\nPrinting all the product which have type = \"Leafy green\"");
            foreach (var leafyGreen in product)
            {
                if (leafyGreen.Type == "Leafy green")
                {
                    Console.WriteLine(leafyGreen.Name + "\t" + leafyGreen.Price + "RS" + "\t" + leafyGreen.Quantity + "\t" + leafyGreen.Type);
                }
            }

            //4. Removing garlic from the list
            Product removeGarlic = product.Find(p => p.Name == "garlic");
            product.Remove(removeGarlic);
            Console.WriteLine("\nGarlic Removed\nTotal number of product left = " + product.Count);

            //5. Adding 50 cabbage to the inventory and printing the final quantity of cabbage in the inventory
            Product cabbage = product.Find(p => p.Name == "Cabbage");
            cabbage.Quantity += 50;
            Console.WriteLine("\nFinal quantity of cabbage in the inventory = {0}", cabbage.Quantity);


            //If user purchase 1kg lettuce, 2 kg zucchini, 1 kg broccoli
            double lettucePrice = 0, zucchiniPrice = 0, broccoliPrice = 0;
            foreach (Product purchaseProduct in product)
            {
                if (purchaseProduct.Name == "Lettuce")
                {
                    lettucePrice = purchaseProduct.Price;
                }
                else if (purchaseProduct.Name == "zucchini")
                {
                    zucchiniPrice = purchaseProduct.Price;
                }
                else if (purchaseProduct.Name == "broccoli")
                {
                    broccoliPrice = purchaseProduct.Price;
                }
            }
            double totalPriceToPay = (lettucePrice * 1) + (zucchiniPrice * 2) + (broccoliPrice * 1);

            //6. Now printing the totalPriceToPay in round figure for that I am using Math.Round() method
            Console.WriteLine("\nFinal rounded price to pay = {0}RS", Math.Round(totalPriceToPay));


            Console.ReadKey();
        }

    }
}