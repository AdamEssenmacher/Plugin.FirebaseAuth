using System;
using System.Threading.Tasks;
namespace Plugin.FirebaseAuth
{
    public interface IPhoneAuthProvider
    {
        string ProviderId { get; }
        string PhoneSignInMethod { get; }
        IPhoneAuthCredential GetCredential(string verificationId, string verificationCode);
        IPhoneAuthCredential GetCredential(IFirebaseAuth auth, string verificationId, string verificationCode);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(string phoneNumber);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(string phoneNumber, TimeSpan timeout);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IFirebaseAuth auth, string phoneNumber);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IFirebaseAuth auth, string phoneNumber, TimeSpan timeout);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(string phoneNumber, IMultiFactorSession multiFactorSession);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(string phoneNumber, IMultiFactorSession multiFactorSession, TimeSpan timeout, bool requiresSmsValidation);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IPhoneMultiFactorInfo phoneMultiFactorInfo, IMultiFactorSession multiFactorSession);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IPhoneMultiFactorInfo phoneMultiFactorInfo, IMultiFactorSession multiFactorSession, TimeSpan timeout, bool requiresSmsValidation);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IFirebaseAuth auth, string phoneNumber, IMultiFactorSession multiFactorSession);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IFirebaseAuth auth, string phoneNumber, IMultiFactorSession multiFactorSession, TimeSpan timeout, bool requiresSmsValidation);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IFirebaseAuth auth, IPhoneMultiFactorInfo phoneMultiFactorInfo, IMultiFactorSession multiFactorSession);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberAsync(IFirebaseAuth auth, IPhoneMultiFactorInfo phoneMultiFactorInfo, IMultiFactorSession multiFactorSession, TimeSpan timeout, bool requiresSmsValidation);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberForTestingAsync(string phoneNumber, string verificationCode);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberForTestingAsync(string phoneNumber, string verificationCode, TimeSpan timeout);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberForTestingAsync(IFirebaseAuth auth, string phoneNumber, string verificationCode);
        Task<PhoneNumberVerificationResult> VerifyPhoneNumberForTestingAsync(IFirebaseAuth auth, string phoneNumber, string verificationCode, TimeSpan timeout);
    }
}
