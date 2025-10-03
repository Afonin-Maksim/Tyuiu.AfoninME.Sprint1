using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AfoninME.Sprint1.Task5.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {

        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            
            return Convert.ToInt32(distance);
        }
    }
}
