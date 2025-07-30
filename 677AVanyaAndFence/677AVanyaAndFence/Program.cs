string[] data = Console.ReadLine().Split(' ');
int n = int.Parse(data[0]);
int h = int.Parse(data[1]);

int[] heights = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int width = 0;

foreach (int height in heights)
{
    if (height > h)
    {
        width += 2; // If the height is greater than h, we need 2 units of width
    }
    else
    {
        width += 1; // Otherwise, we need only 1 unit of width
    }

}

Console.WriteLine(width);
