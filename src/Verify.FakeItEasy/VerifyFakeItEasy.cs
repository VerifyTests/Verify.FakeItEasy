namespace VerifyTests;

public static class VerifyFakeItEasy
{
    public static void Enable() =>
        VerifierSettings.AddExtraSettings(serializer =>
        {
            serializer.Converters.Add(new CallConverter());
            serializer.Converters.Add(new FakeConverter());
        });
}