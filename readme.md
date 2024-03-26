# <img src="/src/icon.png" height="30px"> Verify.FakeItEasy

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/gla1okqvccljt4a8?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-FakeItEasy)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.FakeItEasy.svg)](https://www.nuget.org/packages/Verify.FakeItEasy/)

Adds [Verify](https://github.com/VerifyTests/Verify) support for verifying [FakeItEasy](https://fakeiteasy.github.io/) types.

**See [Milestones](../../milestones?state=closed) for release notes.**


## NuGet package

https://nuget.org/packages/Verify.FakeItEasy/


## Usage

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyFakeItEasy.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Given an interface:

<!-- snippet: ITarget.cs -->
<a id='snippet-ITarget.cs'></a>
```cs
public interface ITarget
{
    void Method(int a, int b);
}
```
<sup><a href='/src/Tests/ITarget.cs#L1-L4' title='Snippet source file'>snippet source</a> | <a href='#snippet-ITarget.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Its `.GetCalls()` can be verified:

<!-- snippet: ReceivedCalls -->
<a id='snippet-ReceivedCalls'></a>
```cs
[Fact]
public Task ReceivedCalls()
{
    var target = A.Fake<ITarget>();
    target.Method(1, 2);
    var calls = Fake.GetCalls(target);
    return Verify(calls);
}
```
<sup><a href='/src/Tests/Tests.cs#L5-L16' title='Snippet source file'>snippet source</a> | <a href='#snippet-ReceivedCalls' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Will result in:

<!-- snippet: Tests.ReceivedCalls.verified.txt -->
<a id='snippet-Tests.ReceivedCalls.verified.txt'></a>
```txt
[
  {
    Method: ITarget.Method(int a, int b),
    Arguments: [
      1,
      2
    ]
  }
]
```
<sup><a href='/src/Tests/Tests.ReceivedCalls.verified.txt#L1-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-Tests.ReceivedCalls.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

A instance of `FakeManager` can also be verified.

<!-- snippet: FakeManager -->
<a id='snippet-FakeManager'></a>
```cs
[Fact]
public Task FakeManager()
{
    var target = A.Fake<ITarget>();
    target.Method(1, 2);
    var fakeManager = Fake.GetFakeManager(target);
    return Verify(fakeManager);
}
```
<sup><a href='/src/Tests/Tests.cs#L18-L29' title='Snippet source file'>snippet source</a> | <a href='#snippet-FakeManager' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
