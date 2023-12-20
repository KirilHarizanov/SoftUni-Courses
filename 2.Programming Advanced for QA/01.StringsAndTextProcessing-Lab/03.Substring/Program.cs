string wordToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(wordToRemove))
{
    int indexOfWordToRemove = text.IndexOf(wordToRemove);
    text = text.Remove(indexOfWordToRemove, wordToRemove.Length);
    //OR
    //text = text.Replace(wordToRemove, "");
}
Console.WriteLine(text);