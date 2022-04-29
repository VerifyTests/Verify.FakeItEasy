using FakeItEasy.Configuration;
// ReSharper disable NotAccessedPositionalProperty.Global

record CallTarget(MethodInfo Method, ArgumentCollection Arguments, object? Return);
