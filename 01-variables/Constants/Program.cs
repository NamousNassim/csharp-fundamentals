const int speedOfLight = 299792458;
const int x = 3 , y = 2 , z=4; // multiple variable declaration 

Console.WriteLine($"{x},{y},{z}"); 

Console.WriteLine(speedOfLight);// speedOfLight = 300000;  this is an error as the const variables must not change values
