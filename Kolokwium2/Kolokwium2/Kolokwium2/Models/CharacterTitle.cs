using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;
[Table("character_titles")]
[PrimaryKey(nameof(CharacterId), nameof(TitleId))]
public class CharacterTitle
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AckquiredAt { get; set; }

    [ForeignKey(nameof(CharacterId))] 
    public Character character { get; set; } = null!;

    [ForeignKey(nameof(TitleId))] 
    public Title title { get; set; } = null!;
}