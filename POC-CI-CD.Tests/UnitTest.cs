namespace POC_CI_CD.Tests
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var a = 1;
            var b = 2;
            // Act

            var expected = 3;
            var result = a + b;
            // Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test2()
        {
            // Arrange
            var a = 1;
            var b = 2;
            // Act

            var expected = 13;
            var result = a + b;
            // Assert
            Assert.Equal(expected, result);
        }
    }
}