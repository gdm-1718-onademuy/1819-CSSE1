using System;

namespace coffeeTypes
{
    class Program 
    {
        static void Main(string[] args)
        {
            var var productCreator1 = new ProductCreator(new EspressoBuilder());
            productCreator1.CreateProduct();
            var product1 = productCreator1.GetProduct();
            product1.ShowInfo();
            
            Console.WriteLine("---------------------------------------------");
            
            var productCreator2 = new ProductCreator(new MachiattoBuilder());
            productCreator2.CreateProduct();
            var product2 = productCreator2.GetProduct();
            product2.ShowInfo();

            Console.ReadKey();
        }
    }
    public interface IProductBuilder{
        void SetSoort();
        void SetStap1();
        void SetStap2();
        void SetStap3();
        void SetStap4();
        Product GetProduct();
    }
    public class EspressoBuilder : IProductBuilder{
        Product objProduct = new Product();
        public void SetSoort(){
            objProduct.soort = "Espresso";
        }
        public void SetStap1(){
            objProduct.stap1 = "Voeg Melk toe";
        }
        public void SetStap2() {
            objProduct.stap2 = "Klop Melk schuim";
        }
        public void SetStap3() {
            objProduct.stap3 = "Voeg espresso toe";
        }
        public void SetStap4() {
            objProduct.stap4 = "Serveer";
        }
        public Product GetProduct(){
            return objProduct;
        }
    }
        public class MachiattoBuilder : IProductBuilder{
            Product objProduct = new Product();
            public void SetSoort(){
                objProduct.soort = "Machiatto";
            }
            public void SetStap1(){
                objProduct.stap1 = "Voeg Melk toe";
            }
            public void SetStap2() {
                objProduct.stap2 = "Klop Melk schuim";
            }
            public void SetStap3() {
                objProduct.stap3 = "Voeg Machiatto toe";
            }
            public void SetStap4() {
                objProduct.stap4 = "Serveer";
            }
            public Product GetProduct(){
             return objProduct;
            }
        }
        public class Product{
            public string soort { get; set; }
            public string stap1 { get; set; }
            public string stap2 { get; set; }
            public string stap3 { get; set; }
            public string stap4 { get; set; }
            public Product()
            {
             
            }
            public void ShowInfo(){
                Console.WriteLine("Soort: {0}", soort);
                Console.WriteLine("Stap1: {0}", stap1);
                Console.WriteLine("Stap2: {0}", stap2);
                Console.WriteLine("Stap3: {0}", stap3);
                Console.WriteLine("Stap4: {0}", stap4);
            }
        }
            public class ProductCreator{
            private readonly IProductBuilder objBuilder;
            
            public ProductCreator(IProductBuilder builder){
                objBuilder = builder;
            }
            
            public void CreateProduct(){
                objBuilder.SetSoort();
                objBuilder.SetStap1();
                objBuilder.SetStap2();
                objBuilder.SetStap3();
                objBuilder.SetStap4();
            }
            public Product GetProduct(){
                return objBuilder.GetProduct();
            }
        }
}
