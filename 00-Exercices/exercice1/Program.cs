Console.WriteLine("First Name : ");
string? firstName = Console.ReadLine();
Console.WriteLine("Age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Height (cm): ");
int  height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("are you a developer : ");
string? isDeveloper = Console.ReadLine()?.ToLower();

Console.WriteLine($"First Name : {firstName}");

Console.WriteLine($"Age: {age} ");

Console.WriteLine($"Height (cm): {height}");

if (isDeveloper == "yes")
{
 Console.WriteLine("you are a dev!");   
}
else if (isDeveloper == "no")
{
    Console.WriteLine("You are  not a developer ");
}
else
{
    Console.WriteLine("Invalid answer for the dev qst");
}