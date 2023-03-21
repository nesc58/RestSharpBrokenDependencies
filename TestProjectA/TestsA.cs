using LibraryA;
using NUnit.Framework;

namespace TestProjectA;

public class TestsA
{
    [Test]
    public void CreateWrappedClient_ShouldNotThrow()
    {
        Assert.DoesNotThrow(() =>
        {
            var wrappedClient = new WrappedClient();
        });
    }
}