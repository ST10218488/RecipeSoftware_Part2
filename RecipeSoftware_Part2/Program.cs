using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSoftware_Part2
{
    using System;
    using System.Collections.Generic;

    namespace RecipeBook
    {
        class Program
        {
            static void Main(string[] args)
            {
                RecipeAdministrator recipeAD= new RecipeAdministrator();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome to the Recipe Book!");
                Console.ResetColor();

                while (true)
                {
                    Console.WriteLine("\nPlease select an option:");
                    Console.WriteLine("1. Add a recipe");
                    Console.WriteLine("2. View all recipes");
                    Console.WriteLine("3. Exit");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("\nLets Start:....");
                            Console.Write("Recipe Name: ");
                            string name = Console.ReadLine();
                            Recipe recipe = new Recipe { Name = name, Ingredients = new List<Ingredient>() };

                            while (true)
                            {
                                Console.Write("\nEnter an ingredient name (or '1' to finish): ");
                                string ingredientName = Console.ReadLine();

                                if (ingredientName.ToLower() == "1")
                                {
                                    break;
                                }

                                Console.Write("Calories: ");
                                int calories = int.Parse(Console.ReadLine());

                                Console.Write("Food group: ");
                                string foodGroup = Console.ReadLine();

                                Ingredient ingredient = new Ingredient { Name = ingredientName, Calories = calories, FoodGroup = foodGroup };
                                recipe.Ingredients.Add(ingredient);
                            }

                            recipeAD.AddRecipe(recipe);

                            Console.WriteLine("\nRecipe added successfully!");
                            break;

                        case "2":
                            Console.WriteLine("\nAll recipes:");
                            foreach (Recipe r in recipeAD.GetRecipesAlphabetical())
                            {
                                Console.WriteLine("- " + r.Name);
                            }

                            Console.Write("\nEnter the name of a recipe to view (or 'back' to return to the main menu): ");
                            string recipeName = Console.ReadLine();

                            if (recipeName.ToLower() == "back")
                            {
                                break;
                            }

                            Recipe selectedRecipe = recipeAD.GetRecipeByName(recipeName);

                            if (selectedRecipe == null)
                            {
                                Console.WriteLine("\nRecipe not found!");
                                break;
                            }

                            Console.WriteLine("\nIngredients for " + selectedRecipe.Name + ":");

                            foreach (Ingredient i in selectedRecipe.Ingredients)
                            {
                                Console.WriteLine("- " + i.Name + " (" + i.Calories + " calories, " + i.FoodGroup + ")");
                            }

                            int totalCalories = selectedRecipe.TotalCalories();
                            Console.WriteLine("\nTotal calories: " + totalCalories);

                            if (totalCalories > 300)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nWarning: This recipe has more than 300 calories!");
                                Console.ResetColor();
                            }

                            break;

                        case "3":
                            Console.WriteLine("\nGoodbye!");
                            return;

                        default:
                            Console.WriteLine("\nInvalid input. Please try again.");
                            break;
                    }
                }
            }
        }




    }
}