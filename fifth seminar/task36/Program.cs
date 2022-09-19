// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

class program
{
    static void Main(String[] args)
    {
        Console.Write("enter array size:\t");
        int elementsCount = int.Parse(Console.ReadLine()!);

        int oddIndexNumberCounter = 0;
        int sum = 0;
        int[] array = new int[elementsCount];

        Random random = new Random();

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = random.Next(0, 1000);

            if (index % 2 != 0)
            {
                sum += array[index];
                Console.WriteLine($"[{index}]" + array[index] + "\t" + "it's odd index");
            }
            else
            {
                Console.WriteLine($"[{index}]" + array[index] + "\t" + "it's even index");
            }
        }
        Console.WriteLine($"the total sum of numbers of odd indices is: \t {sum}");
    }
}