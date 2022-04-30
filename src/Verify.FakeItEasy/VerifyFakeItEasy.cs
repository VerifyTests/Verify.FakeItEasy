namespace VerifyTests;

public static class VerifyFakeItEasy
{
    public static void Enable() =>
        VerifierSettings.ModifySerialization(settings =>
        {
            settings.AddExtraSettings(serializer =>
            {
                serializer.Converters.Add(new CallConverter());
                serializer.Converters.Add(new FakeConverter());
            });
        });
}