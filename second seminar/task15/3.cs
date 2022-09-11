//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.WriteLine("enter day of a week");

int dayNumber = int.Parse(Console.ReadLine());

//это на февраль 

if ((dayNumber > 0 && dayNumber <= 5) || (dayNumber >= 8 && dayNumber <= 12) || (dayNumber >= 15 && dayNumber <= 19) || (dayNumber >= 22 && dayNumber <= 26))
{
    Console.WriteLine("it's a weekday | take a frog");

}
else if ((dayNumber > 5 && dayNumber <= 7) || (dayNumber >= 13 && dayNumber <= 14) || (dayNumber >= 20 && dayNumber <= 21) || (dayNumber >= 27 && dayNumber <= 28))
{
    Console.WriteLine("it's a day of rest");
}
else{
    Console.WriteLine("end of mounth");
}
