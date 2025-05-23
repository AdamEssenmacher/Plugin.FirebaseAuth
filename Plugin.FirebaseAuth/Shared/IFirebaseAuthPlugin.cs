namespace Plugin.FirebaseAuth
{
    public interface IFirebaseAuthPlugin
    {
        IEmailAuthProvider EmailAuthProvider { get; }
        IGoogleAuthProvider GoogleAuthProvider { get; }
        IFacebookAuthProvider FacebookAuthProvider { get; }
        ITwitterAuthProvider TwitterAuthProvider { get; }
        IGitHubAuthProvider GitHubAuthProvider { get; }
        IPhoneAuthProvider PhoneAuthProvider { get; }
        IOAuthProvider OAuthProvider { get; }
        IPlayGamesAuthProvider? PlayGamesAuthProvider { get; }
        IPhoneMultiFactorGenerator PhoneMultiFactorGenerator { get; }
        IFirebaseAuth Instance { get; }
        IFirebaseAuth GetInstance(string appName);
    }
}
