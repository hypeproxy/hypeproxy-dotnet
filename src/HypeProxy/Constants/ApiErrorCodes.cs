using Tapper;

namespace HypeProxy.Constants;

[TranspilationSource]
public struct ApiErrorCodes
{
    public const string UnknownError = "UNKNOWN_ERROR";
    public const string SuckDick = "SUCK_DICK";
    public const string PrivateApi = "PRIVATE_API";

    [TranspilationSource]
    public struct Authentication
    {
        public const string MissingToken = "MISSING_TOKEN";
        public const string ExpiredToken = "EXPIRED_TOKEN";
        public const string MalformedToken = "MALFORMED_TOKEN";
    }
    
    public struct User
    {
        public const string UserNotFound = "USER_NOT_FOUND";
        public const string UserNotAllowed = "USER_NOT_ALLOWED";
        public const string MissingUserId = "MISSING_USER_ID";
    }
    
    public struct OrderValidation
    {
        public const string FailedValidation = "FAILED_VALIDATION";
        
        [Obsolete]
        public const string MissingFieldMaybe = "MAYBE_MISSING_FIELD";
        
        public const string UnavailableQuantity = "UNAVAILABLE_QUANTITY";
        public const string InvalidQuantity = "INVALID_QUANTITY";
        
        public const string InvalidPaymentMethod = "INVALID_PAYMENT_METHOD";
        
        public const string ProductNotFound = "PRODUCT_NOT_FOUND";
        public const string LocationNotFound = "LOCATION_NOT_FOUND";
        public const string ProviderNotFound = "PROVIDER_NOT_FOUND";
        
        public const string InvalidCoupon = "INVALID_COUPON";
        public const string UnprocessablePayment = "UNPROCESSABLE_PAYMENT";
        public const string FuckCondition = "FUCK_CONDITION";
    }

    public struct Features
    {
        public const string UnavailableFeature = "NOT_AVAILABLE_FEATURE";
    }
}