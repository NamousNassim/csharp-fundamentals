# C# type casting 

 - Type casting is when you assign a value of one data type to another type.

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char

# Example  : 

```csharp
int myInt = 9;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);
```