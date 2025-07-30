string year = Console.ReadLine();
bool isBeautiful = false;

while (!isBeautiful)
{
    year = (int.Parse(year) + 1).ToString();
    
    foreach (char digit in year)
    {
        if (year.IndexOf(digit) != year.LastIndexOf(digit))
        {
            isBeautiful = false;
            break;
        }
        isBeautiful = true;
    }
}

Console.WriteLine(year);
