using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? PostId { get; set; }

    public int? UserId { get; set; }

    public string CommentText { get; set; } = null!;

    public DateTime? CommentDate { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
