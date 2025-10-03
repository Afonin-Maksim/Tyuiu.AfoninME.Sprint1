using Tyuiu.AfoninME.Sprint1.Task5.V1.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

         
            int expected = 5;
            int result = ds.DistanceBetweenDots(1, 1, 4, 5);

            Assert.AreEqual(expected, result);
        }
    }
}
