﻿using System;
using System.Collections.Generic;

namespace mission07.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public int? CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public int Year { get; set; }

    public string? Director { get; set; }

    public string? Rating { get; set; }

    public int Edited { get; set; }

    public string? LentTo { get; set; }

    public int CopiedToPlex { get; set; }

    public string? Notes { get; set; }

    public virtual Category? Category { get; set; }
}
