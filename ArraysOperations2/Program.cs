string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] ordersID = orderStream.Split(',');
Array.Sort(ordersID);

foreach(string orderID in ordersID)
{
    if(orderID.Length == 4)
    {
        Console.WriteLine(orderID);
    }
    else
    {
        Console.WriteLine($"{orderID}\t - Error");
    }
}