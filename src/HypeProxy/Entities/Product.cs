using System.ComponentModel;
using System.Text.Json.Serialization;
using HypeProxy.Attributes;
using HypeProxy.Constants;
using Tapper;

namespace HypeProxy.Entities;

/// <summary>
/// Corresponds to a product (Mobile Proxies, Static Residential etc).
/// </summary>
[Orphan]
[TranspilationSource]
public class Product : BaseEntity
{
	public string Name { get; set; }

	// [PublicApiIgnore]
	// public string Terminology { get; set; } = "Proxy";
	
	[PublicApiIgnore]
	public string ShortName { get; set; }

	public string Tagline { get; set; }

	[PublicApiIgnore]
	public string Label { get; set; }

	public string Description { get; set; }
	
	[PublicApiIgnore]
	public string CardDescription { get; set; }

	[PublicApiIgnore]
	public string HtmlContent { get; set; }

	[PublicApiIgnore]
	public string Icon { get; set; }

	[PublicApiIgnore]
	public string IllustrationUrl { get; set; }

	[PublicApiIgnore]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<BillingPeriods> AvailableBillingPeriods { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public int? MinimumOrder { get; set; } = 1;
	
	#nullable enable
	[PublicApiIgnore]
	// [EditorBrowsable(EditorBrowsableState.Never)]
	// [DesignOnly(true)]
	// [Editor("LOl", "JESUS")]
	public string? PreHook { internal get; set; }

	[PublicApiIgnore]
	public string? PostHook { get; set; }
	#nullable disable
}
