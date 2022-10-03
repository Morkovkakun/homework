//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

class program
{
    static void Main(String[] args)
    {
        int height = EnterInt("height: ");
        int width = EnterInt("wight: ");
        int minNumb = EnterInt("min numb of array: ");
        int maxNumb = EnterInt("max numb of array: ");

        int[,] numbers = new int[height, width];
        FillArray(numbers, height, width);
        PrintArray(numbers, height, width);
        Console.WriteLine();
        Sort(numbers, height, width);
        PrintArray(numbers, height, width);

        int EnterInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine()!);
        }

        void FillArray(int[,] numbers, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    numbers[i, j] = new Random().Next(minNumb, maxNumb + 1);
                }
            }
        }

        void PrintArray(int[,] numbers, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{numbers[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
        void Sort(int[,] numbers, int height, int width)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                    {
                        if (numbers[i, k] < numbers[i, k + 1])
                        {
                            int temp = numbers[i, k + 1];
                            numbers[i, k + 1] = numbers[i, k];
                            numbers[i, k] = temp;
                        }
                    }
                }
            }
        }
    }
}
