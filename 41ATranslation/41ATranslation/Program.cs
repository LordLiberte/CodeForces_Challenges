string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

int counter_coincidence = 0;

if (input1.Length != input2.Length)
{
    Console.WriteLine("NO");
    return;
}

for (int i = 0; i < input1.Length; i++)
{
    if (input1[i] == input2[^(i + 1)])
    {
        counter_coincidence++;
    }
}

if (counter_coincidence == input1.Length)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}