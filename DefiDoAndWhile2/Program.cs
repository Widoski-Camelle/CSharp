Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
bool validEntry = false;
string roleChecked = null;

while (validEntry == false)
{
    string? role = Console.ReadLine();
    roleChecked = role.Trim().ToLower();

    if ((roleChecked == "administrator") || (roleChecked == "manager") || (roleChecked == "user"))
        validEntry = true;
        
    else
        Console.WriteLine($"The role name that you entered, \"{roleChecked}\" is not valid. Enter your role name (Administrator, Manager, or User)");
}

Console.WriteLine($"Your input value ({roleChecked}) has been accepted.");