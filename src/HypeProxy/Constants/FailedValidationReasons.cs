namespace HypeProxy.Constants;

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
}