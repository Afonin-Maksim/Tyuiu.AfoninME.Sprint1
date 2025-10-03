using Tyuiu.AfoninME.Sprint1.Task3.V4.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double expected = 22.75;
            double result = ds.PurchaseAmount(2.75, 0.5, 7);

            Assert.AreEqual(expected, result);
        }
    }
}