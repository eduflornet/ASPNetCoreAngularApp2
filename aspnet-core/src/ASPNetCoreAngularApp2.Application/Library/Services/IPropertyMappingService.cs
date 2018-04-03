using System.Collections.Generic;
using ASPNetCoreAngularApp2.Helpers;

namespace ASPNetCoreAngularApp2.Library.Services
{
    public interface IPropertyMappingService
    {
        bool ValidMappingExistsFor<TSource, TDestination>(string fields);

        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
    }
}
