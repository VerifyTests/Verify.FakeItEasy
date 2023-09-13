namespace VerifyTests;

public static class VerifyFakeItEasy
{
    public static bool Initialized { get; private set; }

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();
        VerifierSettings.AddExtraSettings(serializer =>
        {
            serializer.Converters.Add(new CallConverter());
            serializer.Converters.Add(new FakeConverter());
        });
    }
}