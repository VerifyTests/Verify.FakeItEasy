using FakeItEasy;

public class Tests
{
    #region ReceivedCalls

    [Fact]
    public Task ReceivedCalls()
    {
        var target = A.Fake<ITarget>();
        target.Method(1, 2);
        var calls = Fake.GetCalls(target);
        return Verify(calls);
    }

    #endregion

    #region FakeManager

    [Fact]
    public Task FakeManager()
    {
        var target = A.Fake<ITarget>();
        target.Method(1, 2);
        var fakeManager = Fake.GetFakeManager(target);
        return Verify(fakeManager);
    }

    #endregion
}