using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public class Dog
    {
        public Dog()    // Constructor 1
        {

        }

        public Dog(string name, string breed) // Constructor 2
        {
            Name = name;
            Breed = breed;
            Age = 1;
        }

        public Dog(string name, string breed, int age) // Constructor 3
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public void Bark()
        {
            //Console.WriteLine(Name);
            //Console.WriteLine("Bau Bau");
            Console.WriteLine($"{Name}: Bau Bau");
        }
    }
}
