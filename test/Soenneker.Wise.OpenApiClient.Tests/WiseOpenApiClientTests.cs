using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Wise.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class WiseOpenApiClientTests : FixturedUnitTest
{
    public WiseOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
