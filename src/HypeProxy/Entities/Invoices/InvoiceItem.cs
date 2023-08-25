using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tapper;

namespace HypeProxy.Entities.Invoices;

/// <summary>
/// Define an item line of an <see cref="Invoice"/>.
/// </summary>
[TranspilationSource]
[Table("InvoiceItems")]
public partial class InvoiceItem
{
    [Key]
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double TotalAmount { get; set; }
}

public partial class InvoiceItem
{
    [ForeignKey(nameof(Invoice))]
    public Guid InvoiceId { get; set; }
    public virtual Invoice Invoice { get; set; }
}