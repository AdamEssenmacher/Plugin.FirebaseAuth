using System;
namespace Plugin.FirebaseAuth
{
    public class IdTokenEventArgs : EventArgs
    {
        public IFirebaseAuth Auth { get; }

        public IdTokenEventArgs(IFirebaseAuth auth)
        {
            Auth = auth;
        }
    }
}
