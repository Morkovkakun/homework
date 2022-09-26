//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
class program
{
    static void Main(String[] args)
    {
        string[] StringData = { "b1", "k1", "b2", "k2" };
        double[] doubleData = new double[4];
        //из семинара дядька говорил сделать заполнение функцией, ну я пытался
        for (int i = 0; i < doubleData.Length; i++)
        {
            Console.Write(StringData[i] + ":\t");                //долго пытался превратить это в метод, 
            doubleData[i] = double.Parse(Console.ReadLine()!);            //но как в данном случае работает return так и не понял
        }
       
        if (doubleData[2] == doubleData[0] && doubleData[1] == doubleData[3])
        {
            Console.WriteLine("|");
        }
        else if (doubleData[1] == doubleData[0])
        {
            Console.WriteLine("||");
        }
        else
        {
            double x = (doubleData[2] - doubleData[0]) / (doubleData[1] - doubleData[3]);
            double y = (doubleData[1] * x + doubleData[0]);
            Console.WriteLine($"explose in coordinates: \t {x:F3} ; {y:F3}");
        }
    }

}


