namespace POC_CI_CD.Tests
{
    public class UnitTest
    {
        [Fact]
        public void Return_Unit_Test_Success()
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
        public void Return_Unit_Test_Failed()
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
    }
}
