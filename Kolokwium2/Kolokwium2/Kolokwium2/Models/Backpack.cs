using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;
[Table("backpacks")]
[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
public class Backpack
{
    public int CharacterId { get; set; }
    [ForeignKey(nameof(CharacterId))] 
    public Character charackter { get; set; } = null!;

    public int ItemId { get; set; }
    [ForeignKey(nameof(ItemId))] public Item item { get; set; } = null!;
    
    public int Amount { get; set; }
}