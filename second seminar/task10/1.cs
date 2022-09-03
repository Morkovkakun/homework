// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("enter a number consisting of three elements");

int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <= 999)
    {
        Console.WriteLine("second element of number is: " + (number / 10) % 10);

    }
else
    {
        Console.WriteLine("---wrong number---");
    }