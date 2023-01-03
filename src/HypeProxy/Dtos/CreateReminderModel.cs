using System.ComponentModel.DataAnnotations;
using HypeProxy.Attributes;
using Tapper;

namespace HypeProxy.Dtos;

[TranspilationSource]
public class CreateReminderModel
{
    [EmailAddress]
    public string Email { get; set; }

    [RequiredGuid]
    public Guid ProductId { get; set; }
}