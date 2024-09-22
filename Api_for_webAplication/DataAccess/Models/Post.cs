using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Post
{
    public int PostId { get; set; }

    public int? UserId { get; set; }

    public int? RecipeId { get; set; }

    public DateTime? PostDate { get; set; }

    public string? Content { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();

    public virtual Recipe? Recipe { get; set; }

    public virtual User? User { get; set; }
}
