﻿Dictionary<char, int> characters = new();

string input = Console.ReadLine();

foreach (char ch in input)
{
    if (ch == ' ')
    {
        continue;
    }

    if (!characters.ContainsKey(ch))
    {        
        characters.Add(ch, 1);
    }
    else
    {
        characters[ch]++;
    }
}
foreach (var pair in characters)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}