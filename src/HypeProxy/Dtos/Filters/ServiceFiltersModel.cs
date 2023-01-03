namespace HypeProxy.Dtos.Filters;

public class ApplyFilter
{
    public string Parameter { get; set; }
    public dynamic Value { get; set; }
    public bool Blocking { get; set; }
}