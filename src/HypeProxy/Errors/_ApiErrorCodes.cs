namespace HypeProxy.Constants;

[Obsolete]
public enum ApiErrorCodes
{
    UnknownError,
    
    RequiredField,
    
    MissingToken,
    ExpiredToken,
    MalformedToken,
    
    UserNotFound,
    UserNotAllowed,
    MissingUserId,
    
    FailedFieldValidation,
    
    DevelopmentError,
    
    OrderValidationError
}