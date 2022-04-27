using System.Collections.Generic;

namespace BethanyPieShop5._0.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public IEnumerable<Category> AllCategories => throw new System.NotImplementedException();
    }
}
