//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    Console.WriteLine("enter a number consisting of five elements: ");

    string number = Console.ReadLine()!;
    int length = number.Length;
    bool logicTest = true;

    //check palindrome
    for (int i = 0; i < length / 2; i++)
    {
        if (number[i] != number[length - (i + 1)])
        {
            logicTest = false;
            break;
        }
    }

    //if logicTest true, number is palindrome
    if (logicTest)
    {
        Console.WriteLine("{0} is palindrome", number);
    }
    else
    {
        Console.WriteLine("{0} is not palindrome", number);
    }
