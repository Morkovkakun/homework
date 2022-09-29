//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
class program
{
    static int FindNumberInArray(int[,] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (j == number)
                {
                    return j;
                }
            }
        }
        return -1;
    }
    static int EnterNumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine()!);
    }


    static void Main(String[] args)
    {
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 } };

        int number = EnterNumber("Enter number: \t");

        int result = FindNumberInArray(array2D, number);

        string print = (result >= 0) ? "exist" : "not exist";

        Console.WriteLine($"{number} {print}");
    }
}