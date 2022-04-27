using System.Collections.Generic;

namespace BethanyPieShop5._0.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
