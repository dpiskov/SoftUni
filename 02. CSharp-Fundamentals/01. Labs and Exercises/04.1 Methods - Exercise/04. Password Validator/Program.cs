string inputPassword = Console.ReadLine();

bool isLengthValid = IsPasswordLengthValid(inputPassword);
bool isAlphaNumeric = IsPasswordAlphaNumeric(inputPassword);
bool hasTwoDigits = IsPasswordContainingAtLeast2Digits(inputPassword);

if (!isLengthValid)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!isAlphaNumeric)
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!hasTwoDigits)
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (isLengthValid && isAlphaNumeric && hasTwoDigits)
{
    Console.WriteLine("Password is valid");
}

static bool IsPasswordLengthValid(string password)
{
    bool isValid = password.Length >= 6 && password.Length <= 10;
    return isValid;
}

static bool IsPasswordAlphaNumeric(string password)
{
    foreach (char ch in password)
    {
        if (!char.IsLetterOrDigit(ch))
        {
            return false;
        }
    }

    return true;
}

static bool IsPasswordContainingAtLeast2Digits(string password)
{
    int digitsCnt = 0;

    foreach (char ch in password)
    {
        if (char.IsDigit(ch))
        {
            digitsCnt++;
        }
    }

    return digitsCnt >= 2;
}
