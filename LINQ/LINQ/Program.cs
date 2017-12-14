using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person{FirstName="Cameron", LastName="Day", Age=13},
                new Person{FirstName="Rylee", LastName="Santos", Age=32},
                new Person{FirstName="Oliver", LastName="Day", Age=50},
                new Person{FirstName="Devon", LastName="Newman", Age=43},
                new Person{FirstName="Eliza", LastName="Newman", Age=22},
            };

            var result = from p in people
                         //where p.Age < 30
                         orderby p.LastName
                         group p by p.LastName;
                         //select p;

            foreach(var item in result)
            {
                Console.WriteLine(item.Key + " - " + item.Count());
                foreach(var p in item)
                {
                    Console.WriteLine("\t{0} {1}", p.FirstName, p.LastName, p.Age);
                }
            }
            
            /*foreach(var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName, item.Age);
            }*/

            /*var sample = "Test Test Test";
            var result = from c in sample.ToLower() //Just lower characters
                         where c == 't' || c == 'e'
                         orderby c //descending //descending order
                         group c by c;
                         //select c;
            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
            }  */
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
