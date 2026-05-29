void getName()
{
    Console.WriteLine("Username : ");
    string? userName = Console.ReadLine();
    Console.WriteLine($"Username is {userName}");
}

void getAge()
{
    Console.WriteLine("Age : ");
    int? age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Age is {age}");

}



getName();
getAge();