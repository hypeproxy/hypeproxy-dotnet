﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Tapper;

namespace HypeProxy.Constants;

[TranspilationSource]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PaymentMethods
{
    [Display(Name = "Credit Card")]
	CreditCard,
    
    [Display(Name = "Cryptocurrency")]
	Cryptocurrency
}
