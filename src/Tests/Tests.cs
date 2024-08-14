using FakeItEasy;
using Xunit;

public class Tests
{
    #region ReceivedCalls

    [Fact]
    public void ReceivedCalls()
    {
        var target = A.Fake<ITarget>();
        target.Method(1, 2);
        Fake.GetCalls(target);
    }

    #endregion

    #region FakeManager

    [Fact]
    public void FakeManager()
    {
        var target = A.Fake<ITarget>();
        target.Method(1, 2);
        Fake.GetFakeManager(target);
    }

    #endregion
}