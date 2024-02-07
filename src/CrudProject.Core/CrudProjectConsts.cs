using CrudProject.Debugging;

namespace CrudProject
{
    public class CrudProjectConsts
    {
        public const string LocalizationSourceName = "CrudProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9102a5972ddf47d2802dca1040d9966e";
    }
}
