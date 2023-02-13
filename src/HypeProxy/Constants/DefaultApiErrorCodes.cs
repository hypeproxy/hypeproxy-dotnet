using Tapper;

namespace HypeProxy.Constants;

[TranspilationSource]
public enum DefaultApiErrorCodes
{
    UnknownError,
    
    MissingToken,
    ExpiredToken,
    MalformedToken,
    
    UserNotFound,
    UserNotAllowed,
    MissingUserId,
    
    FailedValidation,
    
    // InvalidQuantity,
    // UnavailableAutomaticRenew,
    // ProductNotFound,
    // LocationNotFound,
    // ProviderNotFound,
    // InsufficientQuantityAvailable,
    // InvalidCouponCode,
    // Forbidden
}