namespace HypeProxy.Constants;

[Obsolete]
public enum FailedValidationReasons
{
	InvalidOrder,
	InvalidQuantity,
	InvalidCouponCode,
	ProductNotFound,
	LocationNotFound,
	ProviderNotFound,
	UnavailableAutomaticRenew,
	InsufficientQuantityAvailable,
	Forbidden
}