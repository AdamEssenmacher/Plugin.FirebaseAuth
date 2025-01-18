﻿using System;
using Firebase.Auth;

namespace Plugin.FirebaseAuth
{
    public class FirebaseAuthPluginImplementation : IFirebaseAuthPlugin
    {
        public IEmailAuthProvider EmailAuthProvider { get; } = new EmailAuthProviderWrapper();

        public IGoogleAuthProvider GoogleAuthProvider { get; } = new GoogleAuthProviderWrapper();

        public IFacebookAuthProvider FacebookAuthProvider { get; } = new FacebookAuthProviderWrapper();

        public ITwitterAuthProvider TwitterAuthProvider { get; } = new TwitterAuthProviderWrapper();

        public IGitHubAuthProvider GitHubAuthProvider { get; } = new GitHubAuthProviderWrapper();

        public IPhoneAuthProvider PhoneAuthProvider { get; } = new PhoneAuthProviderWrapper();

        public IOAuthProvider OAuthProvider { get; } = new OAuthProviderWrapper();

        public IPlayGamesAuthProvider? PlayGamesAuthProvider { get; }

        public IGameCenterAuthProvider? GameCenterAuthProvider { get; } = new GameCenterAuthProviderWrapper();

        public IPhoneMultiFactorGenerator PhoneMultiFactorGenerator { get; } = new PhoneMultiFactorGeneratorWrapper();

        public IFirebaseAuth Instance => AuthProvider.Auth;

        public IFirebaseAuth GetInstance(string appName)
        {
            return AuthProvider.GetAuth(appName);
        }
    }
}