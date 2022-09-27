//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("enter the number you want to raise to a power: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("enter degree to which you want to raise the number: ");
int secondNumber = int.Parse(Console.ReadLine()!);
int exit = 1;
for (int i = 0; i < secondNumber; i++)
{
    Console.WriteLine(exit *= number);
}