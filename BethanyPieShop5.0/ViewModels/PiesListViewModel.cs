using BethanyPieShop5._0.Models;
using System.Collections.Generic;

namespace BethanyPieShop5._0.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
