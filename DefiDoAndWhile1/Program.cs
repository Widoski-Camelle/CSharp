Console.WriteLine("Enter an integer value between 5 and 10");
bool validEntry = false;
int verifyNumber = 0;

while (validEntry == false)
{
    string? number = Console.ReadLine();
    validEntry = int.TryParse(number, out verifyNumber);

    if (validEntry)
    {
        if (verifyNumber >= 5 && verifyNumber <= 10 )
            break;

        else
            Console.WriteLine($"You entered {verifyNumber}. Please enter a number between 5 and 10.");
            validEntry = false;
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
}

Console.WriteLine($"Your input value ({verifyNumber}) has been accepted.");