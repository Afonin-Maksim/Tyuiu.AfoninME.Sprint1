using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AfoninME.Sprint1.Task4.V12.Lib
{
    public class DataService : ISprint1Task4V12
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sin(Math.PI * x);
            double denominator = x + Math.Sqrt(Math.Abs(y));

            double result = numerator / denominator;

            return Math.Round(result, 3, MidpointRounding.AwayFromZero);
        }
    }
}