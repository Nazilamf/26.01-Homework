using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _26._01_Homework
{
    //Task1

    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;



        public string GetFullName()
        {
            return this.Name+ " " +this.Surname;
        }


    }

    //Task2

    internal class Student
    {
        public string FullName;
        public string Group;
        public double Point;



        public bool IsGraduated()

        {
            if (Point >= 65)
                return true;
            else return false;

        }


        public string GetInfo()
        {
            return $"FullName: {FullName} - Group : {Group} - Gradueted:{IsGraduated()}";

        }
    }

    //Task3

    internal class Product
    {
        public string Name;
        public double Price;
        public double DiscountPercent;


        public Product(string name, double price, double discountpercent)
        {
            Name= name;
            Price= price;
            DiscountPercent= discountpercent;

        }



    }

    // Task4-Homework
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;




        public string ShowInfo()
        {
            return $"Brand:{Brand} - Model:{Model} - Price: {Price}";
        }




        public Notebook(string brand, string model, double price)
        {
            Brand= brand;
            Model = model;
            Price= price;

        }

        //public Notebook(string brand, string model)
        //{
        //    Brand = brand;
        //    Model = model;
        //}
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human human1 = new Human
            {
                Name = "Leyla",
                Surname = "Abbasova",
                Age = 25

            };

            var fullname = human1.GetFullName();
            Console.WriteLine(fullname);






            Student student1 = new Student
            {

                FullName = "Cavid",
                Group = "P231",
                Point =95

            };

            Student student2 = new Student
            {
                FullName = "Nigar",
                Group = "P451",
                Point =84
            };



            Console.WriteLine(student2.IsGraduated());
            Console.WriteLine(student1.GetInfo());






            //Product[] products = new Product[3];
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine("Mehsul adi:");
            //    string name = Console.ReadLine();

                //double price;
                //do
                //{
                //    Console.WriteLine("Qiymet:");
                //    string pricestr = Console.ReadLine();
                //    price = Convert.ToDouble(pricestr);

                //} while (price<0);

                //    Console.WriteLine("Endirim:");
                //    string discountpercentstr = Console.ReadLine();
                //    double discountpercent = Convert.ToDouble(discountpercentstr);

                //    Product pr = new Product(name, price, discountpercent);
                //    products[i] = pr;


                //};
                //foreach (var item in products)
                //{
                //    Console.WriteLine(item.Name + ' ' + item.Price);
                //}


                //Notebook note1 = new Notebook
                //{
                //    Brand = "HP",
                //    Model = "Pavilion 15",
                //    Price = 1500
                //};

                //Console.WriteLine(note1.ShowInfo());




                Notebook[] notebooks = new Notebook[3];
            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine("Mehsul adi:");
                string brand = Console.ReadLine();

                Console.WriteLine("Mehsul model:");
                string model = Console.ReadLine();

                double price;
                do
                {
                    Console.WriteLine("Mehsul qiymeti:");
                    string pricestr = Console.ReadLine();
                    price = Convert.ToDouble(pricestr);
                } while (price<=0);

                Notebook note = new Notebook(brand, model, price);
                notebooks[i]= note;

               
                
                
            }
            double sum = 0;
            foreach (var item in notebooks)
            {
                sum += item.Price;
            }
            Console.Write("Average:");
            Console.WriteLine(sum/3);

        }

            
        
    }
}




