using Soenneker.Tests.HostedUnit;

namespace Soenneker.Wise.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WiseOpenApiClientTests : HostedUnitTest
{
    public WiseOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
