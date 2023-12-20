//string[] words = Console.ReadLine().Split(" ");

//string output = "";

//for (int i = 0; i < words.Length; i++)
//{
//    string currentWord = words[i];

//    for (int j = 0; j < currentWord.Length; j++)
//    {
//        output += currentWord;
//    }
//}
//Console.WriteLine(output);




string[] strings = Console.ReadLine().Split(" ");

string output = "";

for (int i = 0; i < strings.Length; i++)
{
	string currentWord = strings[i];

	for (int j = 0; j < currentWord.Length; j++)
	{
		output += currentWord;
	}
}

Console.WriteLine(output);