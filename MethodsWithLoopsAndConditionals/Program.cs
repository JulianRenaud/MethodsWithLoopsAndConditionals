using System;
using System.Runtime.CompilerServices;

//---------------LukuWarm Section---------------

//Write a method that will print to the console all numbers 1000 through -1000
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
PrintRange(-1000, 1000);



static void PrintRange(int num1, int num2)
{
    

    for (int i = num1; i <= num2; i++)
    {
        Console.WriteLine(i);
    }
   
}




//Write a method that will print to the console numbers 3 through 999 by 3 each time
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(3000);

Threes(3, 999);

static void Threes(int num1, int num2)
{


    for (int i = num1; i <= num2; i += 3)
    {
        Console.WriteLine(i);
    }

}


//Write a method to accept two integers as parameterss and check whether they are equal or not
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Enter a number: ");
int sameOrDiff = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number to see if it will be the same as the last number: ");
int sameOrDiff2 = Convert.ToInt32(Console.ReadLine());



if (sameOrDiff == sameOrDiff2)
{
    Console.WriteLine("These numbers are the same!");
}
else
{
    Console.WriteLine("These numbers are different!");
}


//Write a method to check whether a given number is even or odd
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Enter a number to see if it is even or odd: ");
int evenOrOdd = Convert.ToInt32(Console.ReadLine());




if (evenOrOdd % 2 == 0)
{
    Console.WriteLine("This number is even!");
}
else
    Console.WriteLine("This number is odd!");






//Write a method to check whether a given number is positive or negative
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Enter a number to see if it is negative or positive: ");
int posOrNeg = Convert.ToInt32(Console.ReadLine());

if (posOrNeg > 0)
{
    Console.WriteLine("This number is positive!");
}
else if (posOrNeg < 0)
    Console.WriteLine("This number is negative!");
else
    Console.WriteLine("0 is neither negative or positive");


//Write a method to read the age of a candidate and determine whether they can vote.
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Enter your age to see if you are old enough to vote: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You are old enough to vote!");
}
else
    Console.WriteLine("You are not old enough to vote!");


//---------------Heatin Up Section---------------

//Write a method to check if an integer (from the user) is in the range -10 to 10
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Enter a number To see if it fits in the range of 10 to -10: ");
int range = Convert.ToInt32(Console.ReadLine());
var range1 = 10;
var range2 = -10;

if (range <= range1 && range >= range2)
{
    Console.WriteLine($"This number is in the range of {range1} to {range2}");
}
else
    Console.WriteLine($"This number is not in the range of {range1} to {range2}");


//Write a method to display the multiplication table (from 1 to 12) of a given integer

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


int constant = 1;
Console.Write("Enter a number to know your number's mulitplication sheets up to 12: ");
int num = Convert.ToInt32(Console.ReadLine());
int originalNumber = num;

constant++;
int z = 1;
Console.WriteLine($"{num} * 1: {num}");


while (constant < 13)
{
    num = originalNumber * constant;
    constant++;
    z++;
    Console.WriteLine($"{originalNumber} * {z}: {num}");

    
}


