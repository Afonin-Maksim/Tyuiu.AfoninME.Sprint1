using Tyuiu.AfoninME.Sprint1.Task5.V1.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x1,y1,x2,y2;

        Console.WriteLine("Введите значение X1:");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y1:");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение X2:");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y2:");
        y2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int z = ds.DistanceBetweenDots( x1, y1, x2, y2);

        Console.WriteLine($"Результат: {z}");



        Console.ReadLine();

    }
}

