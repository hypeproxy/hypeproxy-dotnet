using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Entities;

[Orphan]
[TranspilationSource]
public class Feature : BaseEntity
{
    public string Tag { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    [PublicApiIgnore]
    public string Icon { get; set; }
    
    [PublicApiIgnore]
    public string FrontComponentName { get; set; }
    
    [PublicApiIgnore]
    public string BladeComponentName { get; set; }
    
    [PublicApiIgnore]
    public string ExtraComponentName { get; set; }
}