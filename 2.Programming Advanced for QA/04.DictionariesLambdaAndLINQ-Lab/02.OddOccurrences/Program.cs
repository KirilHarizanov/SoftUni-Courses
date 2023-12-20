string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
	string caseInsensetiveWord = word.ToLower();

	if (wordsCount.ContainsKey(caseInsensetiveWord))
	{
		wordsCount[caseInsensetiveWord] += 1;
	}
	else
	{
		wordsCount.Add(caseInsensetiveWord, 1);
	}
}
foreach (var pair in wordsCount)
{
	if (pair.Value % 2 != 0)
	{
		Console.Write($"{pair.Key} ");
	}
}