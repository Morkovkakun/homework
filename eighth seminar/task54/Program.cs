// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        SumsUp(NewArray(numbers, height, width));

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

        int[] NewArray(int[,] numbers, int height, int width)
        {
            int[] str = new int[height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    str[i] += numbers[i, j];
                }
            }
            return str;
        }

        void SumsUp(int[] numbers)
        {
            int minRow = numbers[0];
            int numberMinRow = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minRow)
                {
                    minRow = numbers[i];
                    numberMinRow = i;
                }
            }
            Console.WriteLine($"{numberMinRow + 1} line have smallest sum of number = {minRow}");
        }
    }
}
