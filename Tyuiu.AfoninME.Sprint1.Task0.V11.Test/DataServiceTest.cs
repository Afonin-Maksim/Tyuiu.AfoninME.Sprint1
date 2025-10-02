using Tyuiu.AfoninME.Sprint1.Task0.V11.Lib;
//Задание
//Написать программуб которая вычисляет выражение 4*5/2-18/2/3 и печатает результат на экране

namespace Tyuiu.AfoninME.Sprint1.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(6, res);



        }
    }
}
