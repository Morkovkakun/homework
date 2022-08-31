int a;
Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine()); 

// тут тоже можно тенарным сделать, но как в шарпе булевые работают я не знаю еще, возможно есть сходства с джавой
if (a % 2 == 0) 
{
Console.WriteLine("Число " + a + " - чётное");
}
else
{
Console.WriteLine("Число " + a + " - нечётное");
}

//завершение по нажатию клавиши

Console.ReadKey();