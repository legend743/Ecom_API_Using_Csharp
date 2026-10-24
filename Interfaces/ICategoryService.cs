using System;
using Ecomm.DTO;

namespace Ecomm.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryDTO>>GetCategoryData();
Task<bool>SaveCategory(CategoryDTO categoryDTO);
}
