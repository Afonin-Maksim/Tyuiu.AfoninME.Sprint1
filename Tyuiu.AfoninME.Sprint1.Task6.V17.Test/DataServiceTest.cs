using Tyuiu.AfoninME.Sprint1.Task6.V17.Lib;
namespace Tyuiu.AfoninME.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestPalindromeWord()
        {
            DataService ds = new DataService();

            bool result = ds.CheckPalindrome("казак");
            Assert.IsTrue(result); 
        }

        
     }
}

