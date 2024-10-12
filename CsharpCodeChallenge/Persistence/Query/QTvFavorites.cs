using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpCodeChallenge.DBConnections;
using CsharpCodeChallenge.DBModels;
using CsharpCodeChallenge.Dto;
using Microsoft.EntityFrameworkCore;

namespace CsharpCodeChallenge.Persistence.Query
{
    public class QTvFavorites
    {
        public Favorite_TV? GetFavoritesByIdFavorite(int idUser, int idShow)
        {
            using (ContextDb dbc = new ContextDb())
            {
                Favorite_TV? favorite = dbc.Favorite_TVs
                    .Where(x => x.idProgram_TV==idShow && x.idUser==idUser)
                    .AsNoTracking()
                    .FirstOrDefault();
                return favorite;
            }
        }
    }
}
