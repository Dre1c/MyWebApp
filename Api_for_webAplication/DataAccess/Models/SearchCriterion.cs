using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class SearchCriterion
{
    public int CriteriaId { get; set; }

    public string CriteriaName { get; set; } = null!;

    public virtual ICollection<RecipeSearchCriterion> RecipeSearchCriteria { get; set; } = new List<RecipeSearchCriterion>();
}
