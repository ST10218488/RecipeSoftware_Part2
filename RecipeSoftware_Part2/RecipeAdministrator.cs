using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSoftware_Part2
{
   
    // Manages a collection of recipes.
    class RecipeAdministrator
    {
        private List<Recipe> recipes = new List<Recipe>();

        // Adds a recipe to the collection.
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        // Gets a recipe by name.
        public Recipe GetRecipeByName(string name)
        {
            return recipes.Find(r => r.Name.ToLower() == name.ToLower());
        }

        // Gets all recipes in alphabetical order by name.
        public List<Recipe> GetRecipesAlphabetical()
        {
            List<Recipe> sortedRecipes = new List<Recipe>(recipes);
            sortedRecipes.Sort((r1, r2) => r1.Name.CompareTo(r2.Name));
            return sortedRecipes;
        }
    }

}

