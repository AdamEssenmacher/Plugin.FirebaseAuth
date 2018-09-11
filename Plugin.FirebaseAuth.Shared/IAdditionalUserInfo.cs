﻿using System;
using System.Collections.Generic;
namespace Plugin.FirebaseAuth
{
    public interface IAdditionalUserInfo
    {
        IDictionary<string, string> Profile { get; }
        string ProviderId { get; }
        string Username { get; }
    }
}
