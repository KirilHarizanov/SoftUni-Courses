//using _00.Demo;

//Dog puppy = new Dog
//{
//    Name = "Sparky",
//    Breed = "Corgi",
//    Age = 3,
//};

//puppy.Bark();

//Dog friend = new Dog();
//friend.Name = "Ivan";
//friend.Breed = "Unknown";
//friend.Age = 3;

//friend.Bark();

using _00.Demo;
using System.Net.Cache;

Dog dog1 = new Dog(); // Calls Constructor 1
Dog dog2 = new Dog("John", "Corgi");   // Calls Constructor 2
Dog dog3 = new Dog("John", "Corgi", 2);   // Calls Constructor 3

Console.WriteLine(dog2.Name); 