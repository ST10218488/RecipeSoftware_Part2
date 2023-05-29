using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RecipeSoftware_Part2.RecipeBook;

namespace RecipeSoftware_Part2
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void GetTotalCalories_Returns_CorrectValue()
        {
            Recipe recipe = new Recipe();

            // Act
            int totalCalories = recipe.TotalCalories();

            // Assert
            Assert.AreEqual(300, totalCalories);
        }
    }
}
