using System;
namespace Plugin.FirebaseAuth
{
    public partial interface IFirebaseAuth
    {
        internal Firebase.Auth.FirebaseAuth ToNative();
    }
}
