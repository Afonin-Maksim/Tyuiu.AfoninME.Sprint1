using Tyuiu.AfoninME.Sprint1.Task2.V18.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int value, valueTwo, valueThree;
            Console.WriteLine("Введите длину параллелепипеда:");
            value = (int)Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину параллелепипеда:");
            valueTwo = (int)Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту параллелепипеда:");
            valueThree = (int)Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int z = ds.CalculateSideSquareParallelepiped(value, valueTwo, valueThree);

            Console.WriteLine($"Площадь боковой поверхности параллелепипеда: {z}");

            Console.ReadLine();

        }
    }
}
