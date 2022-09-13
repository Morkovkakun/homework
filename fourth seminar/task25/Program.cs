//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("enter the number you want to raise to a power: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("enter degree to which you want to raise the number: ");
int secondNumber = int.Parse(Console.ReadLine()!);
//Не могли бы вы дать какие нибудь ресурсы по математике, пожалуйста
//а то я два часа думал почему у меня ничего не работало при exit = 0 *epic_facepalm*
int exit = 1;
for (int i = 0; i < secondNumber; i++)
{
    Console.WriteLine(exit *= number);
}