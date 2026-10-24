using System;
using Ecomm.Data;
using Ecomm.DTO;
using Ecomm.Interfaces;
using Ecomm.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Ecomm.Controllers.Service;

public class CategoryService : ICategoryService
{
    private readonly ApllicationDbContext _applicationDbContext;
    public CategoryService(ApllicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    public async Task<bool> SaveCategory(CategoryDTO categoryDTO)
    {
        try
        {
            CategoryModel category = new CategoryModel
            {

                Title = categoryDTO.Title,
                DisplayId = categoryDTO.DisplayId


            };
            _applicationDbContext.Categories.Add(category);
            await _applicationDbContext.SaveChangesAsync();



            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<List<CategoryDTO>> GetCategoryData()
    {
        var response = await _applicationDbContext.Categories.ToListAsync();
        List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
        foreach (var resp in response)
        {
            CategoryDTO cd = new CategoryDTO();
            cd.Title = resp?.Title;
            cd.DisplayId = resp?.DisplayId;
            categoryDTOs.Add(cd);
        }
        ;
        return categoryDTOs;
    }

}


