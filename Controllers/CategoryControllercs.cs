using Ecomm.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryControllercs : ControllerBase
    {
        List<Category> listOfCategories = new List<Category>
        {
new Category{Id=1,Title="Samsung",DisplayId=1},
new Category{Id=2,Title="Nokia",DisplayId =2},
new Category{Id=3,Title="Apple",DisplayId=3},
new Category{Id=4,Title="Xiomi",DisplayId=4}

        };
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return listOfCategories;
        }
        [HttpPost]
        public ActionResult<Category> AddCategory([FromBody] Category category)
        {
            listOfCategories.Add(category);
            return new JsonResult(category);

        }
        [HttpPut("{id}")]
        public ActionResult<Category> update(int id, [FromBody] Category category)
        {
            listOfCategories[id] = category;
            return new JsonResult(listOfCategories);

        }
        [HttpDelete("{id}")]
        public ActionResult<Category>delete(int id)
        {
            listOfCategories.RemoveAt(id);
            return new JsonResult(listOfCategories);
            
        }
    }
}
