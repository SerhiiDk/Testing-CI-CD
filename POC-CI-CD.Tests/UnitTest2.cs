namespace POC_CI_CD.Tests;

public class UnitTest2
{
    [Fact]
    public void Return_Unit_Test2_Failed()
    {
        // Arrange
        var a = 1;
        var b = 2;
        // Act
        var expected = 4;
        var result = a + b;
        // Assert
        Assert.Equal(expected, result);
    }

}

