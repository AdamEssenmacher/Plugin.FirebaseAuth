using System;
namespace Plugin.FirebaseAuth
{
    public class AuthStateEventArgs : EventArgs
    {
        public AuthStateEventArgs(IFirebaseAuth auth)
        {
            Auth = auth;
        }

        public IFirebaseAuth Auth { get; }
    }
}
