using ShamiCafe.Debugging;

namespace ShamiCafe
{
    public class ShamiCafeConsts
    {
        public const string LocalizationSourceName = "ShamiCafe";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "460ba82d1fc94b22aa1b717978b9ffea";
    }
}
