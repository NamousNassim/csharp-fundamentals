int x = 20;
int y = 10;

if (x > y)
{
    Console.WriteLine($"{x} is greater than {y}");
}
else
{
    Console.WriteLine($"{y} is greater than {x}");
}

int time = 20;
string result = (time < 18) ? "good day" : "good evening";
Console.WriteLine($"{result}");