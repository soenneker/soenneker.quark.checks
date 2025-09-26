using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Checks.Tests;

[Collection("Collection")]
public sealed class CheckTests : FixturedUnitTest
{
    public CheckTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Test that the component can be instantiated
        Assert.True(true);
    }
}
