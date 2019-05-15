using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NimbleCalandar.Localization
{
    public static class NimbleCalandarLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NimbleCalandarConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NimbleCalandarLocalizationConfigurer).GetAssembly(),
                        "NimbleCalandar.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
