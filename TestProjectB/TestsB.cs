using LibraryB;
using NUnit.Framework;

namespace TestProjectB;

public class TestsB
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