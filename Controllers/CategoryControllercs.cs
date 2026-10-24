using Ecomm.DTO;
using Ecomm.Interfaces;
using Ecomm.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Ecomm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryControllercs : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryControllercs(ICategoryService categoryService ){
            _categoryService=categoryService;
        }
        List<CategoryModel> listOfCategories = new List<CategoryModel>
        {
new CategoryModel{Id=1,Title="Samsung",DisplayId=1},
new CategoryModel{Id=2,Title="Nokia",DisplayId =2},
new CategoryModel{Id=3,Title="Apple",DisplayId=3},
new CategoryModel{Id=4,Title="Xiomi",DisplayId=4}

        };
        [HttpGet]
        public Task<List<CategoryDTO>> Get()
        {
            return _categoryService.GetCategoryData();
        }
        [HttpPost]
        public async Task<ActionResult<bool>>AddCategory([FromBody] CategoryDTO category)
        {
          bool result=await _categoryService.SaveCategory(category);
            if (!result)
            {
                return BadRequest(false);
            }
    
           return BadRequest(true);

        }
        [HttpPut("{id}")]
        public ActionResult<CategoryModel> update(int id, [FromBody] CategoryModel category)
        {
            listOfCategories[id] = category;
            return new JsonResult(listOfCategories);

        }
        [HttpDelete("{id}")]
        public ActionResult<CategoryModel> delete(int id)
        {
            listOfCategories.RemoveAt(id);
            return new JsonResult(listOfCategories);

        }

        [HttpDelete]
        public IActionResult DeleteAll()
        {
            listOfCategories.Clear(); // Removes all items from the list
            return Ok("All categories have been deleted.");
        }


    }
}
