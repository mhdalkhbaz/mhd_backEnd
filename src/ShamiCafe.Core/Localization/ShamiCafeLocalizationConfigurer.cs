using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ShamiCafe.Localization
{
    public static class ShamiCafeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ShamiCafeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ShamiCafeLocalizationConfigurer).GetAssembly(),
                        "ShamiCafe.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
