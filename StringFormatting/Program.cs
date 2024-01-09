// Mise en forme composite
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

// Interpolation de chaîne
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");

// Mise en forme de valeurs monétaires
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Mise en forme des nombres
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// Mise en forme des pourcentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");



decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);