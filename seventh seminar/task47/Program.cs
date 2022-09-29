// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
class program
{
    static void Main(String[] args)
    {
        int hight = EnterInt("Enter hight: \t");
        int wight = EnterInt("Enter wight: \t");

        double[,] numb = new double[hight, wight];

        FillAndPrintArray();


        int EnterInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine()!);
        }

        void FillAndPrintArray()
        {
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < wight; j++)
                {
                    numb[i, j] = GetRandomNumber(-10, 11);

                    Console.Write($"{numb[i, j],3:F2} \t");
                }
                System.Console.WriteLine();
            }
        }
      
        static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }


}
