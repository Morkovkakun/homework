//Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
class program
{
    static void Main(String[] args)
    {
        //ограниченное число скучно, можно ведь то кол-во которое хочет пользователь :Ь

        Console.Write("enter mass your array:\t");
        int elementsCount = int.Parse(Console.ReadLine()!);
        int[] newArray = new int[elementsCount];

        for (int i = 0; i < newArray.Length; i++){
            Console.Write($"enter elements of array for index {i}:\t");
            newArray[i] = int.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < newArray.Length; i++){

            Console.Write(newArray[i] + "\t");
        }
    }
}