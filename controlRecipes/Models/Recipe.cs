using System;
using System.Collections.Generic;

namespace controlRecipes.Models
{
    public record Recipe
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public IEnumerable<string> Directions { get; init; }    
        public IEnumerable<string> Ingredient { get; init; }
        public DateTime Updated { get; init; }
    }
}
