string pangram = "The quick brown fox jumps over the lazy dog";

// Funtions to use : Split(), ToCharArray(), Array.Reverse() and String.Join()
// Result waited   : ehT kciuq nworb xof spmuj revo eht yzal god

string[] items = pangram.Split(' ');

List<string> reversedWords = new List<string>();

foreach (string item in items)
{
    char[] everyWord = item.ToCharArray();
    Array.Reverse(everyWord);
    reversedWords.Add(new string(everyWord));
}

string pangramReversed = String.Join(' ', reversedWords);
Console.WriteLine(pangramReversed);