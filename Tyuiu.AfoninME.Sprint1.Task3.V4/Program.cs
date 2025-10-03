using Tyuiu.AfoninME.Sprint1.Task3.V4.Lib;
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

            double x, y;
            Console.WriteLine("Введите цену тетради:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену обложки:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество комплектов:");
            int z;
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double a = ds.PurchaseAmount(x, y, z);

            Console.WriteLine($"Стоимость покупки: {a}");

            Console.ReadLine();

        }
    }
}
