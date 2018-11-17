using System;

namespace OOP
{
    public class MenuItems{ 
    public class Product
    { //Product = basic class
        //product properties
        public String Name = "";
        public String Type = "";
        List<string> ingredients = new List<string>();
    }
    public class Price 
    { //Price = basic class
        //price properties
        public String valuta = "";
        public Double value = 0;
    }}
    public class MenuItem1 : MenuItem1{
        public static void Main(String[] args){
    //title of console window 
        Console.Title = "Menu items";

        //make some menu items
        //without parameters
        Product product1 = new Product();
        product1.Name;
        product1.Type;
        product1.ingredients;

        //with x parameters
        Product product2 = new Product();
        product2.Name = "Spa";
        product2.Type = "drinks";
        product2.ingredients.Add("water");

        //with y parameters
        Product product3 = new Product();
        product3.Name = "Leo";
        product3.Type = "biscuits";
        product3.ingredients.Add("milk", "chocolat", "sugar");

        //keep console window open
        Console.ReadKey();
}}}


    