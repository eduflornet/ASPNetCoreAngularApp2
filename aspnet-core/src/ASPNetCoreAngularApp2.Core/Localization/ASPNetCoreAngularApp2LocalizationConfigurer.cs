using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ASPNetCoreAngularApp2.Localization
{
    public static class ASPNetCoreAngularApp2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ASPNetCoreAngularApp2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ASPNetCoreAngularApp2LocalizationConfigurer).GetAssembly(),
                        "ASPNetCoreAngularApp2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
