using System.Collections.Generic;

namespace ASPNetCoreAngularApp2.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
