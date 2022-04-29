namespace VerifyTests;

public static class VerifyFakeItEasy
{
    public static void Enable() =>
        VerifierSettings.ModifySerialization(settings =>
        {
            var converter = new CallConverter();
            settings.AddExtraSettings(serializer => serializer.Converters.Add(converter));
        });
}