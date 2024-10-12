
using CsharpCodeChallenge.Business;
using CsharpCodeChallenge.Bussiness;
using CsharpCodeChallenge.DBModels;
using Monitor = CsharpCodeChallenge.Helpers.Monitor;

namespace CsharpCodeChallenge.Controllers
{
    public class TvFavoritesController: ITvFavoritesController
    {
        private ITvShowBusiness _TvShowBusiness = new TvShowBusiness();
        private ITvFavoritesBusiness _TvFavoritesBusiness = new TvFavoritesBusiness();
        public async Task<string> ChangeStatusFavorite(string? id)
        {
            try
            {
                if (!int.TryParse(id, out int idShow)) {
                    Monitor.printConsole("No valido");
                    return "No valido";
                }

                Programs_TV? program = await _TvShowBusiness.GetTvShowById(idShow);
                if (program == null) {
                    Monitor.printConsole("No existe el programa");
                    return "No existe el programa";
                }

                string resp = await _TvFavoritesBusiness.ChangeStatusFavorite(idShow);
                Monitor.printConsole(resp);
                return resp;

            }catch (Exception ex)
            {
                Monitor.printConsole(ex.ToString());
                return "Error";
            }
        }
    }
}
