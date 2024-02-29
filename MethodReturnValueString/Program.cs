// Method that returns reversed word
string ReverseWord(string word) 
{
    string result = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

// To test //
// string word = "snake";

// Console.WriteLine(word);
// Console.WriteLine(ReverseWord(word));

// Method that returns each word reversed of a sentence
string ReverseSentence(string input) 
{
    string result = "";

    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

// To test //
// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));