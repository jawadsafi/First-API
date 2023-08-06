using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using controlRecipes.Models;

namespace controlRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes([FromQuery]int count)
        {
            Recipe[] recipes = {
                new() {Title = "Butter Chicken"},
                new() {Title = "Manto"},
                new() {Title = "Qabuli Palaw"}
            };

            return Ok(recipes.Take(count));

        }

        [HttpPost]

        public ActionResult CreateNewRecipes([FromBody] Recipe newRecipe)
        {
                bool badThingsHappened = false;
                if(badThingsHappened)
            {
                return BadRequest();
            }
            return Created("", newRecipe);
        }

        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();
            return NoContent(); 
        }
        
    }
}
