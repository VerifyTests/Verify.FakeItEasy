using FakeItEasy.Core;

class CallConverter :
    WriteOnlyJsonConverter<ICompletedFakeObjectCall>
{
    public override void Write(VerifyJsonWriter writer, ICompletedFakeObjectCall call)
    {
    }
}