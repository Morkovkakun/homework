// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
class program
{
    static void Main(String[] args)
    {

        int number;
        
        Console.WriteLine("Enter the number of array elements: \t");
        number = Convert.ToInt16(Console.ReadLine());
        int[] array = new int[number];

        int countOfNumber = 0;

        while (countOfNumber < number)
        {
            Console.WriteLine($"Enter number [{countOfNumber}]:");
            array[countOfNumber] = int.Parse(Console.ReadLine());
            countOfNumber++;
        }

        for (countOfNumber = 0; countOfNumber < number; countOfNumber++)
        {
            Console.WriteLine($"[{countOfNumber}]:\t " + array[countOfNumber]);
        }

        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"sum of positive array elements:\t {count}");
        Console.ReadKey();
    }
}
