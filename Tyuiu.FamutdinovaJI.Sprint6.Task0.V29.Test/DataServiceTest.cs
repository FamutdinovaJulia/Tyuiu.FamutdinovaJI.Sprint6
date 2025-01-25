using Tyuiu.FamutdinovaJI.Sprint6.Task0.V29.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint6.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.722;
            Assert.AreEqual(wait, res);
        }
    }
}