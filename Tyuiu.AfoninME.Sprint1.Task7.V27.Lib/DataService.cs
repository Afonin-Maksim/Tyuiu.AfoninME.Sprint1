using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AfoninME.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double part1 = (Math.Cos(x * x) + Math.Sin(y * y)) / (Math.Sin(y) + 1);
            double part2 = (x * y - 12) / (15 + Math.Cos(x));
            double z = part1 - part2;

            return Math.Round(z, 3, MidpointRounding.AwayFromZero);
        }
    }
}
