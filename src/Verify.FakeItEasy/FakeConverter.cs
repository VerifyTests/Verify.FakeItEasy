class FakeConverter :
    WriteOnlyJsonConverter<FakeManager>
{
    public override void Write(VerifyJsonWriter writer, FakeManager fake) =>
        writer.Serialize(Fake.GetCalls(fake.Object!));
}