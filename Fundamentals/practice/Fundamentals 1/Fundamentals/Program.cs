﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// //Create a Loop that prints all values from 1-255

for (int i = 1; i<=255 ; i++)
{
    Console.WriteLine(i);
}

// ++++++++++++++Using While+++++++++++++
// int i=1;
// while(i<=255)
// {
//     Console.WriteLine(i);
//     i++;
// }

//Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both

for (int i = 1; i<=100; i++)
{
    if( (i%3==0 || i%5==0 )&& !(i%3==0 && i%5==0) )
    Console.WriteLine(i);
}

//++++++++++++++Using While+++++++++++++
// int i=1;
// while(i<=100)
// {
//     if( (i%3==0 || i%5==0 )&& !(i%3==0 && i%5==0) )
//     Console.WriteLine(i);
//     i++;
// }

//Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, 
//and "FizzBuzz" for numbers that are multiples of both 3 and 5
for (int i = 1; i<=100; i++)
{
    if ((i%3==0) && (i%5==0))
    Console.WriteLine(i+"FizzBuzz");
    else if (i%3==0)
    Console.WriteLine(i+"Fizz");
    else if (i%5==0)
    Console.WriteLine(i+"Buzz");
}
//++++++++++++++Using While+++++++++++++
// int i=1;
// while (i<=100)
// {
//     if ((i%3==0) && (i%5==0))
//     Console.WriteLine(i+"FizzBuzz");
//     else if (i%3==0)
//     Console.WriteLine(i+"Fizz");
//     else if (i%5==0)
//     Console.WriteLine(i+"Buzz");
//     i++;
// }





