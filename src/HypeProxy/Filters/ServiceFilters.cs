using System.ComponentModel;

namespace HypeProxy.Filters;

public class ServiceFilters
{
    // public readonly List<ApplyFilter> CustomFilters = new();
    //
    // public ServiceFilters()
    // {
    // }
    //
    // public ServiceFilters(string parameter, Guid value) => Add(parameter, value);

    [DisplayName("onlyFeatured")]
    public bool IsFeatured { get; set; }
    
    // [DisplayName("sort")]
    // public ListSortDirection Sort { get; set; }
    
    // [DisplayName("reverse")]
    // public bool IsReverse { get; set; }
    
    // public ServiceFilters Add(string parameter, dynamic value, bool blocking = true)
    // {
    //     CustomFilters.Add(new ApplyFilter
    //     {
    //         Parameter = parameter,
    //         Value = value,
    //         Blocking = blocking
    //     });
    //     return this;
    // }
}

// public class ApplyFilter
// {
// }

// public class ApplyFilter
// {
//     public string Parameter { get; set; }
//     public dynamic Value { get; set; }
//     public bool Blocking { get; set; }
// }