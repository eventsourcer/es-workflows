namespace tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1,1);
    }
    [Fact]
    public void Test2()
    {
        int[] numbers = [1, 2, 3];
        Assert.Equal(3, numbers.Count());
    }

}