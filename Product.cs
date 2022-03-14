using System;
namespace Assignment_Generics{
    class Product{
        public string Name ;
        public string Type ;
        public int Quantity;
        public double Price ;

        public Product(){   
        }
        public Product(string name,double price ,int quantity ,string type){
            this.Name = name;
            this.Type = type;
            this.Quantity = quantity;
            this.Price = price;
        }

    }
}