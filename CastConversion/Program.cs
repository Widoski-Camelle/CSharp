string[] values = { "12,3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (string value in values)
{
    decimal result;
    
    if (decimal.TryParse(value, out result))
    {
        total += result;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");