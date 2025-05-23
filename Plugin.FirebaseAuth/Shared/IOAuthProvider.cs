﻿namespace Plugin.FirebaseAuth
{
    public interface IOAuthProvider
    {
        IAuthCredential GetCredential(string providerId, string idToken, string? accessToken = null, string? rawNonce = null);
    }
}
