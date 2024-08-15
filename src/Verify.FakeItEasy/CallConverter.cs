class CallConverter :
    WriteOnlyJsonConverter<ICompletedFakeObjectCall>
{
    public override void Write(VerifyJsonWriter writer, ICompletedFakeObjectCall call)
    {
        var target = new CallTarget
        (
            call.Method,
            call.Arguments,
            call.ReturnValue
        );
        writer.Serialize(target);
    }
}