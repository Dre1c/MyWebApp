using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class FavoriteRecipe
{
    public int UserId { get; set; }

    public int RecipeId { get; set; }

    public DateTime? AddedDate { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
