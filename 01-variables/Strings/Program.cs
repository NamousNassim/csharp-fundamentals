string greetings = "Hello";
Console.WriteLine($"lenght of the word {greetings} is {greetings.Length}");

Console.WriteLine($"Capital {greetings} is {greetings.ToUpper()}");
Console.WriteLine($"Lower {greetings} is {greetings.ToLower()}");

Console.WriteLine($"the second char of {greetings} is {greetings[1]}");

char letter = 'o';

Console.WriteLine($"position of the char o is {greetings.IndexOf(letter)}");