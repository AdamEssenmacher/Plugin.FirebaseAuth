﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plugin.FirebaseAuth
{
    public interface IMultiFactorResolver
    {
        IMultiFactorSession Session { get; }
        IEnumerable<IMultiFactorInfo> Hints { get; }
        IFirebaseAuth Auth { get; }
        Task<IAuthResult> ResolveSignInAsync(IMultiFactorAssertion multiFactorAssertion);
    }
}
