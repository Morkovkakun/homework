//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("give me some number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number; i++)

    Console.WriteLine(" : " + i * i * i + " : ");
 
 //можно конечно их запихнуть в массив, потом вывести все красиво
