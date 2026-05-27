void explicitCasting()
{
   int myInt = 10;
    double myDouble =myInt; 

    Console.WriteLine(myInt); // output is 9
    Console.WriteLine(myDouble); // output is 9
}

void conversion()
{
    int myInt = 1;


    Console.WriteLine(Convert.ToString(myInt));
    Console.WriteLine(Convert.ToDouble(myInt));
    Console.WriteLine(Convert.ToBoolean(myInt));
}

explicitCasting();
conversion();