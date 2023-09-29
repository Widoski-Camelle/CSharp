string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");
    
    string mySentence;

    string newString = myString;
    
    while (periodLocation != -1)
    {
        mySentence = newString.Remove(periodLocation);

        newString = newString.Substring(periodLocation + 1).TrimStart();

        periodLocation = newString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = newString.Trim();
    Console.WriteLine(mySentence);
}