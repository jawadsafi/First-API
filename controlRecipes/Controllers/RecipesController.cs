using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controlRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public string[] GetDishes()
        {
            string[] dishes = { "Oxtail", "CurryChicken", "Dumplings" };
            return dishes;
        }
    }
}
