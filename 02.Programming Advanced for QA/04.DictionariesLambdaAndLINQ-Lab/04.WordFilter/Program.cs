string[] words = Console.ReadLine().Split(" ").ToArray();

string[] result = words.Where(x => x.Length % 2 == 0).ToArray();

foreach (string word in result)
{
    Console.WriteLine(word);
}



//string[] strings = Console.ReadLine().Split(" ").Where(x => x.Length % 2 == 0).ToArray();

//foreach (string s in strings)
//{
//    Console.WriteLine(s);
//}