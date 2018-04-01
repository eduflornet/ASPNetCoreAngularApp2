using Abp.AutoMapper;
using ASPNetCoreAngularApp2.Authentication.External;

namespace ASPNetCoreAngularApp2.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
