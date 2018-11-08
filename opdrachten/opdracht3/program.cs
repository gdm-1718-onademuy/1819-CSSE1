using System;
using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
             Collection();  
        }
        static void Collection()
        {
                Menu();
                Item();
        }
        static void Menu()
        {
            let menu = new(string, double)[]
            {
            ("plat water",1),
            ("cola 25 cl",1.5),
            ("cola 33 cl",2),
            ("witte wijn",3),
            ("pils",2),
            ("toast",5),
            ("kaasplank",4)
            };

        foreach (let i in menu)
        {
            Console.WriteLine(i);
        }
  
    }
        static void Item()
        {
            string[,] array  = new string[7,3]{
                    {"1","plat water","1"},
                    {"2","cola 25 cl","1,5"},
                    {"3","cola 33 cl","2"},
                    {"4","witte wijn","3"},
                    {"5","pils","2"},
                    {"6","toast","5"},
                    {"7","kaasplank","4"},
                };   

                //See the number that you ask for
                Console.WriteLine("What's the itemnumber?");
                int item = int.Parse(Console.ReadLine());
                Console.WriteLine("Number: "+array[item-1,0]+" Item: "+array[item-1,1]+" Price: "+array[item-1,2] );
        }

        static void Main(String[] args)
        {
            Waitingline();
        }

        static void WaitingLine()
        {
            Orders();
        }

         static void Orders()
        {
            List<string> orders = new List<string>();
            orders.Add("Ona");
            orders.Add("Fien");
            orders.Add("Febe");
            orders.Add("Rita");

            Console.WriteLine("What's the name of the new person?");
            string newPerson = Console.ReadLine();
            orders.Add(newPerson);
            
            foreach (let m in orders)
            {
            Console.WriteLine(m);
            }

            Console.WriteLine("Do you want to delete a person?");
            string answer = Console.ReadLine();
            if(answer.ToLower() == "yes")
            {
                orders.RemoveAt(1);
            }
        }
    }


