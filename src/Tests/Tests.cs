using FakeItEasy;

[UsesVerify]
public class Tests
{
    #region ReceivedCalls

    [Fact]
    public Task Test()
    {
        var target = A.Fake<ITarget>();
        target.Method(1, 2);
        return Verify(Fake.GetCalls(target));
    }

    #endregion
}