﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSoftware_Part2
{

    // Represents an ingredient in a recipe.
    public class Ingredient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string FoodGroup
        {
            get; set;
        }
    }
}