using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class RecipeSearchCriterion
{
    public int RecipeId { get; set; }

    public int CriteriaId { get; set; }

    public string? Value { get; set; }

    public virtual SearchCriterion Criteria { get; set; } = null!;

    public virtual Recipe Recipe { get; set; } = null!;
}
