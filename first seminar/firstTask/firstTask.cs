Console.WriteLine("Введите два числа");

string firstNumber = Console.ReadLine();

string secondNunber = Console.ReadLine();

int intFirstNumber = int.Parse(firstNumber);

int intSecondNunber = int.Parse(secondNunber);

if (intFirstNumber > intSecondNunber)
{
    Console.WriteLine(intFirstNumber + " > " + intSecondNunber);
}
else
{
    Console.WriteLine(intSecondNunber + " > " + intFirstNumber);
}