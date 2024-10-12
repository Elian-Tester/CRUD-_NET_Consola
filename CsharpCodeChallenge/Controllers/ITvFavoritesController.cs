using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodeChallenge.Controllers
{
    public interface ITvFavoritesController
    {
        Task<string> ChangeStatusFavorite(string? id);
    }
}
