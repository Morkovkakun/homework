//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
class program
{
    static void Main(String[] args)
    {
        int height = EnterInt("height: ");
        int width = EnterInt("wight: ");
        int minNumb = EnterInt("min numb of array: ");
        int maxNumb = EnterInt("max numb of array: ");

        int[,] first = new int[height, width];
        int[,] second = new int[height, width];

        FillArray(first, height, width);
        FillArray(second, height, width);
        PrintArray(first, height, width);
        Console.WriteLine();
        PrintArray(second, height, width);
        Console.WriteLine("-------------------------");
        MultiplyArrays(first, second);
        PrintSecondArray(first, second);



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

        int[,] MultiplyArrays(int[,] first, int[,] second)
        {
            int[,] numbers = new int[first.GetLength(0), second.GetLength(1)];

            for (int i = 0; i < first.GetLength(0); ++i)
            {
                for (int j = 0; j < second.GetLength(0); ++j)
                {
                    for (int k = 0; k < second.GetLength(1); ++k)
                    {
                        numbers[i, k] += first[i, j] * second[j, k];
                    }
                }
            }
            return numbers;
        }

        void PrintSecondArray(int[,] first, int[,] second)
        {
            int[,] numbers = MultiplyArrays(first, second);

            for (int i = 0; i < first.GetLength(0); ++i)
            {
                for (int j = 0; j < second.GetLength(1); ++j)
                {
                    Console.Write($"{numbers[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

    }
}