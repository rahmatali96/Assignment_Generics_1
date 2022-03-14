using System;
namespace Assignment_Generics
{
    public class Program{

        static void Main(string[] args){
            var inventory = new InventoryList<Product>();
            inventory.Add(new Product("lettuce", 10.5 , 50 , "Leafy green"));
            inventory.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            inventory.Add(new Product("pumpkin", 30, 30, "Marrow"));
            inventory.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            inventory.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            inventory.Add(new Product("yam", 30, 50, "Root"));
            inventory.Add(new Product("spinach", 10, 100, "Leafy green"));
            inventory.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            inventory.Add(new Product("garlic", 30, 20, "Leafy green"));
            inventory.Add(new Product("silverbeet", 10, 50, "Marrow"));

            System.Console.WriteLine($"Number of Products : {inventory.getCount()}");
            inventory.Add(new Product("Potato",10, 50, "Root"));
            System.Console.WriteLine($"After Adding product Quantity : {inventory.getCount()}");
            //find number of list as Leafy Green
            var products = inventory.findByType("Leafy green");
            Console.WriteLine("Total number of products of type {0} : {1}","Leafy green",products.Count());
            foreach (var product in products){
                Console.WriteLine($"{product.Name} {product.Quantity} Rs.{product.Price}");
            }
            //removing garlic
            inventory.remove("garlic");
            //adding cabbage quantity
            inventory.addQuantity("cabbage",50);

            inventory.calculateBill();
            Console.ReadLine();
        }
    
    }
}