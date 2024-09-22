using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class DifficultyLevel
{
    public int DifficultyId { get; set; }

    public string DifficultyName { get; set; } = null!;

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
