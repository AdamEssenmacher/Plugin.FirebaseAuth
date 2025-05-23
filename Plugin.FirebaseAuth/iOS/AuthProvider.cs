using System;
using System.Collections.Concurrent;
using Firebase.Auth;

namespace Plugin.FirebaseAuth
{
    internal static class AuthProvider
    {
        private static readonly ConcurrentDictionary<Auth, Lazy<AuthWrapper>> Auths = new();

        public static AuthWrapper Auth { get; } = new(Firebase.Auth.Auth.DefaultInstance!);

        public static AuthWrapper GetAuth(string appName)
        {
            var coreApp = Firebase.Core.App.From(appName);
            if (coreApp == null)
                throw new Exception("Firebase app not found");
            Auth? auth = Firebase.Auth.Auth.From(coreApp);
            if (auth == null)
                throw new Exception("Firebase auth not found");
            return GetAuth(auth);
        }

        public static AuthWrapper GetAuth(Auth auth)
        {
            // ReSharper disable once PossibleUnintendedReferenceComparison
            if (auth == Firebase.Auth.Auth.DefaultInstance)
            {
                return Auth;
            }
            return Auths.GetOrAdd(auth, key => new Lazy<AuthWrapper>(() => new AuthWrapper(key))).Value;
        }
    }
}
