public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyFakeItEasy.Enable();

        #endregion

        VerifyDiffPlex.Initialize();
    }
}