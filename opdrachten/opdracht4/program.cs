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
    public class MenuItem1 : MenuItems{ //sub class
        public static void Main(String[] args){
    //title of console window 
        Console.Title = "Menu items";

        //make some menu items
        //without parameters
        MenuItem m1 = new MenuItems();
        m1.MenuItem.Name;
        m1.MenuItem.Type;
        m1.MenuItem.ingredients;
        m1.MenuItem1.valuta;
        m1.MenuItem1.value;

        //with x parameters
        MenuItem m2 = new MenuItem();
        m2.MenuItem.Name = "Spa";
        m2.MenuItem.Type = "drinks";
        m2.MenuItem.ingredients.Add("water");
        m2.MenuItem1.valuta = "€";
        m2.MenuItem1.value = 1.5;

        //with y parameters
        MenuItem m3 = new MenuItem();
        m3.MenuItem.Name = "Leo";
        m3.MenuItem.Type = "biscuits";
        m3.MenuItem.ingredients.Add("milk", "chocolat", "sugar");
        m3.MenuItem1.valuta = "€";
        m3.MenuItem1.value = 2;

        //put them in a list
        List<String> listMenuItems = new List<string>();
        list.Add(m1);
        list.Add(m2);
        list.Add(m3);

        //watch in console
        Console.WriteLine(listMenuItems.ToString);
       
        //sort by on the elements: HOW?
        //alfabetic (by name), by price low to high/high to low, by type of product...

        //keep console window open
        Console.ReadKey();
}}}


    