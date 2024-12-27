namespace Tyuiu.BerestenDS.Sprint7.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path1 = @"C:\Users\Пользователь\source\repos\Tyuiu.BerestenDS.Sprint7\CSV\SavedGoods.csv";
            FileInfo fileInfo = new FileInfo(path1);
            string path2 = @"C:\Users\Пользователь\source\repos\Tyuiu.BerestenDS.Sprint7\CSV\SavedSuppliers.csv";
            FileInfo fileInfo2 = new FileInfo(path2);
            bool fileExist = fileInfo.Exists;
            bool fileExist2 = fileInfo2.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
            Assert.AreEqual(wait, fileExist2);
        }
    }
}