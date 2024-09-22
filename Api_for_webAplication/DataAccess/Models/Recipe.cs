using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? ImageUrl { get; set; }

    public int? CookingTime { get; set; }

    public int? Servings { get; set; }

    public virtual ICollection<FavoriteRecipe> FavoriteRecipes { get; set; } = new List<FavoriteRecipe>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<RecipeSearchCriterion> RecipeSearchCriteria { get; set; } = new List<RecipeSearchCriterion>();

    public virtual ICollection<RecipeStep> RecipeSteps { get; set; } = new List<RecipeStep>();

    public virtual User? User { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    public virtual ICollection<DifficultyLevel> Difficulties { get; set; } = new List<DifficultyLevel>();

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
