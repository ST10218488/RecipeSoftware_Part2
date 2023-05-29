using RecipeSoftware_Part2.RecipeBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSoftware_Part2
{
    // Represents a recipe.
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        // Calculates the total number of calories in the recipe.
        public int TotalCalories()
        {
            int totalCalories = 0;

            foreach (Ingredient i in Ingredients)
            {
                totalCalories += i.Calories;
            }

            return totalCalories;
        }
    }
}
