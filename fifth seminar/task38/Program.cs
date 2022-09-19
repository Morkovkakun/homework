// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[8];
        int difference = 0, max = 0, min = 100;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"[{i}] : " + array[i]);
        }

        difference = max - min;
        Console.WriteLine($" max: {max} min: {min}  difference: {difference} ");
    }
}