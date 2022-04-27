string s_x = Console.ReadLine();
int x = int.Parse(s_x);
int y = 1;
while (y <= x)
{
    if (y % 2 == 0)
    {
        Console.Write($"{y},");
        y++;
    }
    else
    {
        y++;
    }
}
