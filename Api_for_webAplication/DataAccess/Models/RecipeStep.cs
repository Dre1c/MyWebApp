﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class RecipeStep
{
    public int StepId { get; set; }

    public int? RecipeId { get; set; }

    public int StepNumber { get; set; }

    public string Instruction { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
