using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models;

public partial class Direction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte direction_id { get; set; }
    [Required]
    public string? direction_name { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<Discipline> Disciplines { get; set; } = new List<Discipline>();
}
