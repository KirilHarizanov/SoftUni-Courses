//string str = "Hello World";

//str = str + " Again!";

//Console.WriteLine(str);

//char index = str[3];

//Console.WriteLine(index);

//string name = Console.ReadLine();

//Console.WriteLine("Hi " + name + '!');

//string str = "stringToCharArray";

//char[] arr = str.ToCharArray();

//Console.WriteLine(string.Join("|", arr));

//Concatenating
//string text = "Hello" + ", " + "World!";

//string text = "Hello, ";

//text += "Kiril!";

//Console.WriteLine(text);

//string greet = "Hello, ";
//string name = "Kiril";

//string result = string.Concat(greet, name);

//Console.WriteLine(result);

//string firstWord = "Hay!";
//string secondWord = "World?";

//Console.WriteLine(firstWord + secondWord);

//firstWord += secondWord;

//Console.WriteLine(firstWord);

//Console.WriteLine(string.Concat(firstWord, secondWord));

//string wordA = "Hello";
//string wordB = "Hi";
//string wordC = "Hola";

//Console.WriteLine(string.Join("|", wordA, wordB, wordC));

//string s = "abc";
//string[] strings = new string[3];
//for (int i = 0; i < strings.Length; i++)
//{
//    strings[i] = s;
//}
//string repeat = string.Join(" ", strings);
//Console.WriteLine(repeat);

//string fruits = "banana, apple, kiwi, banana, apple";
//Console.WriteLine(fruits.IndexOf("banana")); // 0
//Console.WriteLine(fruits.IndexOf("orange")); // -1

//string fruits = "banana, apple, kiwi, banana, apple";
//Console.WriteLine(fruits.LastIndexOf("banana")); // 21
//Console.WriteLine(fruits.LastIndexOf("orange")); // -1

//string text = "I love fruits.";
//Console.WriteLine(text.Contains("fruits"));
//// True
//Console.WriteLine(text.Contains("banana"));
//// False


////Substring(int startIndex, int length)

//string card = "10C";
//string power = card.Substring(0, 2);
//Console.WriteLine(power); // 10

////Substring(int startIndex)

//string text = "My name is John";
//string extractWord = text.Substring(11);
//Console.WriteLine(extractWord); // John

//Split with one separator:
//string text = "Hello, john@softuni.org, you have been using john @softuni.org in your registration";
//string[] words = text.Split(", ");
//// words[]: "Hello","john@softuni.org","you have been…"

//Split with many separators:
//char[] separators = new char[] { ' ', ',', '.' };
//string text = "Hello, I am John.";
//string[] words = text.Split(separators);
//// "Hello", "I", "am", "John"

//StringSplitOptions.RemoveEmptyEntries - remove empty indexes of string/array/list

//string text = "Hello, john@softuni.org, you have been using john @softuni.org in your registration.";
//string replacedText = text.Replace("john@softuni.org", "john@softuni.com");
//Console.WriteLine(replacedText);
//// Hello, john@softuni.com, you have been using john @softuni.com in your registration.

//using System.Text;

//StringBuilder output = new StringBuilder();

//output.Append("Hello!");
//output.Append("World?");

//Console.WriteLine(output); //"Hello!World?"





////Concatenation VS. StringBuilder
///////Concatenation
//using System.Diagnostics;

//Stopwatch sw = new Stopwatch();
//sw.Start();
//string text = "";
//for (int i = 0; i < 200000; i++)
//    text += i;
//sw.Stop();
//Console.WriteLine(sw.ElapsedMilliseconds); // 73625

///////StringBuilder
//using System.Diagnostics;
//using System.Text;

//Stopwatch sw = new Stopwatch();
//sw.Start();
//StringBuilder text = new StringBuilder();
//for (int i = 0; i < 200000; i++)
//    text.Append(i);
//sw.Stop();
//Console.WriteLine(sw.ElapsedMilliseconds); // 16

//using System.Text;

//StringBuilder sb = new StringBuilder();

//sb.Append("Hello!");
//sb.AppendLine("World!");
//sb.AppendLine("World?!?");
//sb.Clear();
//sb.Insert(0, "INSERTED!");
//sb.Replace("Peter", "George"); //oldValue, newValue

//string result = sb.ToString();
//Console.WriteLine(result);

//Console.WriteLine(sb.Length);
//Console.WriteLine(sb[0]);