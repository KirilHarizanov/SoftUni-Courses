string text = Console.ReadLine();

PrintVowelsCount(text);

static void PrintVowelsCount(string text)
{
    int count = 0;

    for (int letter = 0; letter <= text.Length - 1; letter++)
    {
        char currentLetter = text[letter];

        if (currentLetter == 'A' 
            || currentLetter == 'a'
            || currentLetter == 'O'
            || currentLetter == 'o'
            || currentLetter == 'U'
            || currentLetter == 'u'
            || currentLetter == 'E'
            || currentLetter == 'e'
            || currentLetter == 'I'
            || currentLetter == 'i')
        {
            count++;
        }
    }
    Console.WriteLine(count);
}