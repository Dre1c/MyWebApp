using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Reaction
{
    public int ReactionId { get; set; }

    public string ReactionType { get; set; } = null!;

    public int? UserId { get; set; }

    public int? PostId { get; set; }

    public DateTime? ReactionDate { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
