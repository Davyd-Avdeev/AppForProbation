namespace AppForProbation.Tests
{
    /// <summary>
    /// Класс тестов, принимающий вывод в консоли методов проверок
    /// </summary>
    public class Tests
    {
        private const string ExpectedForFirstTest = "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz";
        private const string ExpectedForSecondTest = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz";        
        private const string ExpectedForThirdTest = "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, dog-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestForFirstExample()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                AppForProbation.Tests.TestForExamples.TestForFirstExample();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForFirstTest, result);
            }
        }

        [Test]
        public void TestForSecondExample()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                AppForProbation.Tests.TestForExamples.TestForSecondExample();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForSecondTest, result);
            }
        }

        [Test]
        public void TestForThirdExample()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                AppForProbation.Tests.TestForExamples.TestForThirdExample();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForThirdTest, result);
            }
        }
    }
}