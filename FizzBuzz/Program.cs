for (int counter = 1; counter <= 100; counter++)
{
    if((counter % 3 == 0) && (counter % 5 == 0))
        Console.WriteLine($"{counter} - FizzBuzz");
    else if (counter % 3 == 0)
        Console.WriteLine($"{counter} - Fizz");
    else if (counter % 5 == 0)
        Console.WriteLine($"{counter} - Buzz");
    else
        Console.WriteLine(counter);
}
