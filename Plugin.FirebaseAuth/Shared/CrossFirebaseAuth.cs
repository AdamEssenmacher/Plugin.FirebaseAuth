using System;
namespace Plugin.FirebaseAuth
{
    /// <summary>
    /// Cross FirebaseAuth
    /// </summary>
    public static class CrossFirebaseAuth
    {
        static Lazy<IFirebaseAuthPlugin?> implementation = new Lazy<IFirebaseAuthPlugin?>(() => CreateFirebaseAuth(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => implementation.Value == null ? false : true;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static IFirebaseAuthPlugin Current
        {
            get
            {
                IFirebaseAuthPlugin? ret = implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IFirebaseAuthPlugin? CreateFirebaseAuth()
        {
            #if IOS || ANDROID
            return new FirebaseAuthPluginImplementation();
            #else
            return null;
            #endif
        }

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

    }
}
