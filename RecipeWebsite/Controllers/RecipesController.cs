using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecipeData;

namespace RecipeWebsite.Controllers
{
    public class RecipesController : Controller
    {
        // GET: Recipes
        public ActionResult Index(int id)
        {
            // /Recipes/Index/1 fix route to remove Index?

            var recipeRepository = new Repository<Recipe>("Recipe");

            var recipe = recipeRepository.FindById(id);

            return View(recipe);
        }
    }
}