//[0-9]+  matches non - empty sequence of digits
//[A-Z][a-z]+ matches a capital + 1 or more small letters

//[A-Z][a-z]+ [A-Z][a-z]+ => "John Smith"

//[abc] – matches any character that is either a, b or c
//[^abc] – matches any character that is not a, b or c
//[0-9] – character range: matches any digit from 0 to 9

//\w – matches any word character (a-z, A-Z, 0-9, _)
//\W – matches any non-word character (the opposite of \w)
//\s – matches any white-space character
//\S – matches any non-white-space character (the opposite of \s)
//\d – matches any decimal digit (0-9)
//\D – matches any non-decimal character (the opposite of \d)
//\b - border

//*  matches the previous element zero or more times
//+  matches the previous element one or more times
//?  matches the previous element zero or one time
//{3}  matches the previous element exactly 3 times

//\d{2}-(\w{3})-\d{4} => "22-Jan-2015" (captures the matched subexpression as numbered group)
//^(?:Hi|hello),\s*(\w+)$ => "Hi, Peter" (defines a non - capturing group)
//(?<day>\d{2})-(?<month>\w{3})-(?<year>\d{4}) => "22-Jan-2015" (defines a named capturing group)

//RegEx in C#:

//using System.Text.RegularExpressions;

//string input = Console.ReadLine();
//string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
//Regex regex = new Regex(pattern);
//MatchCollection matches = regex.Matches(input);
//Console.WriteLine(string.Join(" ", matches));

//IsMatch(text):
//string text = "Today is 2015-05-11";
//string pattern = @"\d{4}-\d{2}-\d{2}";
//Regex regex = new Regex(pattern);
//bool containsValidDate = regex.IsMatch(text);
//Console.WriteLine(containsValidDate); // True

//Match(text) - Returns the first match of a given pattern:
//string text = "Nakov: 123";
//string pattern = @"([A-Z][a-z]+): (\d+)";
//Regex regex = new Regex(pattern);
//Match match = regex.Match(text);

//Console.WriteLine(match.Groups.Count); // 3
//Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]);
//Console.WriteLine("Name: {0}", match.Groups[1]); // Nakov
//Console.WriteLine("Number: {0}", match.Groups[2]); // 123

//Matches(text) - returns a collection of matches:
//string text = "Nakov: 123, Branson: 456";
//string pattern = @"([A-Z][a-z]+): (\d+)";
//Regex regex = new Regex(pattern);
//MatchCollection matches = regex.Matches(text);
//Console.WriteLine("Found {0} matches", matches.Count);
//foreach (Match match in matches)
//{
//    Console.WriteLine("Name: {0}", match.Groups[1]);
//}    
//// Found 2 matches
//// Name: Nakov
//// Name: Branson

//Replace(string text, string replacement) – replaces all strings that match the pattern with the provided replacement:
//string text = "Nakov: 123, Branson: 456";
//string pattern = @"\d{3}";
//string replacement = "999";
//Regex regex = new Regex(pattern);
//string result = regex.Replace(text, replacement);
//Console.WriteLine(result);
//// Nakov: 999, Branson: 999

//Split(text) – splits the text by the pattern and returns string[]:
//string text = "1 2 3 4";
//string pattern = @"\s+";
//string[] results = Regex.Split(text, pattern);
//Console.WriteLine(string.Join(", ", results));
//// 1, 2, 3, 4