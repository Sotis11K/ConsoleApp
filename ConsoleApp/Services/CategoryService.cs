using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;


        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public CategoryEntity CreateCategory(string categoryName)
        {
            var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
            categoryEntity ??= _categoryRepository.Create(new CategoryEntity { CategoryName = categoryName });

            return categoryEntity;
        }

        public CategoryEntity GetCategoryByName (string categoryName)
        {
            var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
            return categoryEntity;
        }


        public CategoryEntity GetCategoryById(int id)
        {
            var categoryEntity = _categoryRepository.Get(x => x.Id == id);
            return categoryEntity;
        }

        public IEnumerable<CategoryEntity> GetCategories()
        {
            var categories = _categoryRepository.GetAll();
            return categories;
        }

        public CategoryEntity UpdateCategory(CategoryEntity categoryEntity)
        {
            var uptadedCategoryEnitty = _categoryRepository.Update(x => x.Id == categoryEntity.Id, categoryEntity);
            return uptadedCategoryEnitty;
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(x => x.Id == id);
        }
    }
}
