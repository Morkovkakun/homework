Console.WriteLine("Введите три числа");

string firstNumber = Console.ReadLine()!;
string secondNumber = Console.ReadLine()!;
string thirdNumber = Console.ReadLine()!;

int intFirstNumber = int.Parse(firstNumber);
int intSecondNumber = int.Parse(secondNumber);
int intThirdNumber = int.Parse(thirdNumber);


//знаю тенарные операторы из жавы
int max = intSecondNumber > intFirstNumber ? intSecondNumber : intFirstNumber;
max = max > intThirdNumber ? max : intThirdNumber;

Console.WriteLine("максимально число = " + max);