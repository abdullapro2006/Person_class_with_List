// See https://aka.ms/new-console-template for more information



using System.Net.Cache;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace program
{
 
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        
        public static void Main(string[] args)
        {
            var pr1 = new Person()
            {
                Name = "Abdullah",
                Age = 16
            };
            var pr2 = new Person() 
            { 
              Name = "Jafar",
              Age = 18
            };
            var pr3 = new Person()
            {
                Name = "Ismayil",
                Age = 20
            };
            var pr4 = new Person()
            {
              Name = "Murad",
              Age = 17
            };
            var pr5 = new Person()
            {
                Name = "Aqil",
                Age = 19
            };
            var pr6 = new Person()
            {
                Name = "Emil",
                Age = 22
            };
            var pr7 = new Person()
            {
                Name = "Musa",
                Age = 24
            };
            var pr8 = new Person()
            {
                Name = "Elvin",
                Age = 25
            };
            var pr9 = new Person()
            {
                Name = "Elnur",
                Age = 27
            };
            var pr10 = new Person()
            {
                Name = "Sadiq",
                Age = 30
            };

            var list = new List<Person>();
            list.Add(pr1);
            list.Add(pr2);
            list.Add(pr3);
            list.Add(pr4);
            list.Add(pr5);
            list.Add(pr6);
            list.Add(pr7);
            list.Add(pr8);
            list.Add(pr9);
            list.Add(pr10);
            Console.WriteLine("Please enter name:");
            string input = Console.ReadLine();
            var result = list.Find(x => x.Name == input);

            if (result == null)
            {
                Console.WriteLine("Not founded:(");
            }
            else
            {
                Console.WriteLine("Founded:)");
            }
            Console.Read();




        }
    }
}