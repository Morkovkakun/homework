//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

class program
{
    static void Main(String[] args)
    {
        Console.Write("enter array size:\t");
        int elementsCount = int.Parse(Console.ReadLine()!);

        int evenNumberCounter = 0;
        int[] array = new int[elementsCount];

        Random random = new Random();

        foreach (int index in array) //практикую так сказать "обезличенность" кода
        {
            array[index] = random.Next(100, 999);

            if (array[index] % 2 == 0)
            {
                evenNumberCounter++;
                Console.WriteLine(array[index] + "\t" + evenNumberCounter);
            }
            else
            {
                Console.WriteLine(array[index] + "\t" + "it's odd number");
            }
        }
        Console.WriteLine($"total even numbers is: \t {evenNumberCounter}");
    }
}
