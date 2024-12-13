using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBasicOutput()
        {
            Assert.Equal("Великая теорема Ферма: доказательство оставлено для потомков!", Program.GetFermatMessage());
        }

        [Theory]
        [InlineData(3, 4, 5, 2)]
        [InlineData(5, 12, 13, 2)]
        public void TestPythagoreanTriple(int a, int b, int c, int n)
        {
            Assert.True(Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n));
        }

        [Fact]
        public void TestImpossibleProof()
        {
            Assert.Throws<NotImplementedException>(() => Program.ProveFermat());
        }
    }
}