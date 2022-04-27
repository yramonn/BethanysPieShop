using System.Collections.Generic;
using System.Linq;

namespace BethanyPieShop5._0.Models
{
    public interface IPieRepository
{
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
