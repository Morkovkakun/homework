// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("size:");
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int[,] array = new int[row, col];
        Random rand = new Random();
        int[] sum = new int[col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                array[i, j] = rand.Next(0, 10);

            }
        }
        Console.WriteLine("");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {

                Console.Write(array[i, j] + "\t");

                sum[i] += array[j, i];
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        foreach (double elem in sum)
        {
            Console.Write($"{(elem / col):F2} \t");
        }

    }
}