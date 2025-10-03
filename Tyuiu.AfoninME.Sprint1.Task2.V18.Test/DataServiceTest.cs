using Tyuiu.AfoninME.Sprint1.Task2.V18.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            
            int expected = 40;
            int result = ds.CalculateSideSquareParallelepiped(2, 3, 4);

            Assert.AreEqual(expected, result);
        }
    }
}