using System;
using System.Collections.Generic;

namespace coffeeBuilder
{
    class Program 
    {
        static void Main(string[] args)
        {
            CoffeeBuilder builder;
            //create coffee with coffeebuilder
            Coffee coffee = new Coffee();

            //construct the coffees
            builder = new EspressoBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new MacchiatoBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new RistrettoBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new MochaBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new IrishBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new FrappeBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new LatteBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new GlaceBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new AmericanoBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();

            builder = new CappuccinoBuilder();
            coffee.Construct(builder);
            builder.Coffee.Show();
            

            //wait for user
            Console.ReadKey();
        }
    }
    //The director class
    class Coffee
    {
        public void Construct(CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.BuildTaste();
            coffeeBuilder.BuildMilk();
            coffeeBuilder.BuildSize();
        }
    }
    abstract class CoffeeBuilder
    {
        protected Coffee coffee;

        public Coffee Coffee
        {
            get {return coffee; }
        }

        public abstract void BuildTaste();
        public abstract void BuildMilk();
        public abstract void BuildSize();
    }

    //ESPRESSO
    class EspressoBuilder : CoffeeBuilder
    {
        public EspressoBuilder()
        {
            coffee = new Coffee("Espresso");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "normal";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "none";
        }
        public override void BuildSize()
        {
            coffee["size"] = "normal";
        }
    }

    //MACCHIATO
    class MacchiatoBuilder : CoffeeBuilder
    {
        public MacchiatoBuilder()
        {
            coffee = new Coffee("Macchiato");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "soft";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "milk";
        }
        public override void BuildSize()
        {
            coffee["size"] = "large";
        }
    }

    //RISTRETTO
    class RistrettoBuilder : CoffeeBuilder
    {
        public RistrettoBuilder()
        {
            coffee = new Coffee("Ristretto");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "strong";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "none";
        }
        public override void BuildSize()
        {
            coffee["size"] = "small";
        }
    }

    //MOCHA
    class MochaBuilder : CoffeeBuilder
    {
        public MochaBuilder()
        {
            coffee = new Coffee("Mocha");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "chocolate";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "milk";
        }
        public override void BuildSize()
        {
            coffee["size"] = "large";
        }
    }

    //IRISH
    class IrishBuilder : CoffeeBuilder
    {
        public IrishBuilder()
        {
            coffee = new Coffee("Irish");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "whisky";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "whipped cream";
        }
        public override void BuildSize()
        {
            coffee["size"] = "large";
        }
    }

    //FRAPPE
    class FrappeBuilder : CoffeeBuilder
    {
        public FrappeBuilder()
        {
            coffee = new Coffee("Frappe");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "cold";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "milk and whipped cream";
        }
        public override void BuildSize()
        {
            coffee["size"] = "large";
        }
    }

    //LATTE
    class LatteBuilder : CoffeeBuilder
    {
        public LatteBuilder()
        {
            coffee = new Coffee("Latte");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "soft";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "milk";
        }
        public override void BuildSize()
        {
            coffee["size"] = "normal";
        }
    }

    //GLACE
    class GlaceBuilder : CoffeeBuilder
    {
        public GlaceBuilder()
        {
            coffee = new Coffee("Glace");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "ice cream";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "milk";
        }
        public override void BuildSize()
        {
            coffee["size"] = "large";
        }
    }

    //AMERICANO
    class AmericanoBuilder : CoffeeBuilder
    {
        public AmericanoBuilder()
        {
            coffee = new Coffee("Americano");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "water-ish";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "none";
        }
        public override void BuildSize()
        {
            coffee["size"] = "large";
        }
    }

    //CAPPUCCINO
    class CappuccinoBuilder : CoffeeBuilder
    {
        public CappuccinoBuilder()
        {
            coffee = new Coffee("Cappuccino");
        }
        public override void BuildTaste()
        {
            coffee["taste"] = "soft";
        }
        public override void BuildMilk()
        {
            coffee["milk"] = "milk";
        }
        public override void BuildSize()
        {
            coffee["size"] = "normal";
        }
    }

    //the coffee class
    class Coffee
    {
        private string _coffeeType;
        private Dictionary<string,string,string> _parts =
        new Dictionary<string,string,string>();

        //constructor
        public Coffee(string coffeeType)
        {
            this._coffeeType = coffeeType;
        }

        //indexer
        public string this[string key]
        {
            get {return _parts[key];}
            set {_parts[key] = value;}
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Coffee Type: {0}", _coffeeType);
            Console.WriteLine(" Taste : {0}", _parts["taste"]);
            Console.WriteLine(" Milk : {0}", _parts["milk"]);
            Console.WriteLine(" Size: {0}", _parts["size"]);
        }
    }
}
