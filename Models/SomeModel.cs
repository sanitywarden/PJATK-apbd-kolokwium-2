using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium1.Models;

[Table("SomeModel")]
[PrimaryKey(nameof(id))]
public class SomeModel
{
    // Model sluzy do mapowania rzeczy w bazie danych
    /* [Key], [ForeignKey("SomeId")], [PrimaryKey(nameof(something), nameof(somethingelse)]
     * [MaxLength(length)]
     * public virtual Something something { get; set; } 
     */

    public int id { get; set; }
}