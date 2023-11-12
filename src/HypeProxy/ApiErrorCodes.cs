using Tapper;

namespace HypeProxy;

public struct ApiErrorCodes
{
    public const string UnknownError = "UNKNOWN_ERROR";
    public const string PrivateApi = "PRIVATE_API";
    public const string RateLimitReached = "RATE_LIMIT_REACHED";

    [TranspilationSource]
    public struct Authentication
    {
        public const string MissingToken = "MISSING_TOKEN";
        public const string ExpiredToken = "EXPIRED_TOKEN";
        public const string MalformedToken = "MALFORMED_TOKEN";
    }
    
    public struct User
    {
        public const string NotFound = "USER_NOT_FOUND";
        public const string NotAllowed = "USER_NOT_ALLOWED";
        public const string MissingUserId = "MISSING_USER_ID";
    }
    
    public struct OrderValidation
    {
        public const string UnprocessablePayment = "UNPROCESSABLE_PAYMENT";
        public const string UnexpectedConditions = "UNEXPECTED_CONDITIONS";
        public const string FailedValidation = "FAILED_VALIDATION";
        public const string UnavailableQuantity = "UNAVAILABLE_QUANTITY";
        
        public const string InvalidPaymentMethod = "INVALID_PAYMENT_METHOD";
        public const string InvalidBillingCycle = "INVALID_BILLING_CYCLE";
        public const string InvalidQuantity = "INVALID_QUANTITY";
        public const string InvalidCoupon = "INVALID_COUPON";
        
        public const string ProductNotFound = "PRODUCT_NOT_FOUND";
        public const string LocationNotFound = "LOCATION_NOT_FOUND";
        public const string ProviderNotFound = "PROVIDER_NOT_FOUND";
        
        public const string IncompleteRequest = "INCOMPLETE_REQUEST";
    }

    public struct Features
    {
        public const string UnavailableFeature = "UNAVAILABLE_FEATURE";
    }
}