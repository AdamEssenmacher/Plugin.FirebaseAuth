using Firebase.Auth;

namespace Plugin.FirebaseAuth
{
    public partial interface IFirebaseAuth
    {
        internal Auth ToNative();
    }
}
