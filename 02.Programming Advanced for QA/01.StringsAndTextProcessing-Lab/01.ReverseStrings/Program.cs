string word = Console.ReadLine();

while (word != "end")
{
    string reversed = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        reversed += word[i];
    }

    //char[] wordsAsCharArray = word.ToCharArray();
    //Array.Reverse(wordsAsCharArray);
    //string reversedWord = string.Join(" ", wordsAsCharArray);
    //OR
    //string reversedWord = string.Join(" ", word.ToCharArray().Reverse());
    //OR
    //string reversedString = new string(word.ToCharArray().Reverse().ToArray());

    Console.WriteLine($"{word} = {reversed}");

    word = Console.ReadLine();
}