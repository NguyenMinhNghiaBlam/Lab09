using StudentService;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student st = new Student();

            double c = st.Score = 10;

            Assert.AreEqual(c, 10);
        }
    }
}