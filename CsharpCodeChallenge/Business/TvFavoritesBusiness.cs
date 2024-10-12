using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpCodeChallenge.DBConnections;
using CsharpCodeChallenge.DBModels;
using CsharpCodeChallenge.Persistence.Query;
using CsharpCodeChallenge.Persistence.Repository;

namespace CsharpCodeChallenge.Business
{
    public class TvFavoritesBusiness: ITvFavoritesBusiness
    {
        private IRepository<Favorite_TV> _repositoryFavorite = new Repository<Favorite_TV>(new ContextDb());
        QTvFavorites qTvFavorites = new QTvFavorites();

        public async Task<string> ChangeStatusFavorite(int id)
        {
            string resp = "";
            Favorite_TV? favorite = qTvFavorites.GetFavoritesByIdFavorite(1, id);
            if (favorite == null)
            {
                await _repositoryFavorite.CreateAsync(
                        new Favorite_TV()
                        {
                            isFavorite = 1,
                            idProgram_TV = id,
                            idUser = 1
                        }
                    );
                resp = "Se agregó a favoritos";
            }
            else
            {
                favorite.isFavorite = favorite.isFavorite == 1 ? 0 : 1;
                await _repositoryFavorite.UpdateAsync(favorite);
                resp = favorite.isFavorite == 1 ? "Se agregó a favoritos" : "Se eliminó de favoritos";
            }
            return resp;
        }
    }
}
