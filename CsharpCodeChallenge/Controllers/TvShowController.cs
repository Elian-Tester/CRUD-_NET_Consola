using CsharpCodeChallenge.Business;
using CsharpCodeChallenge.Bussiness;
using CsharpCodeChallenge.Dto;
using Monitor = CsharpCodeChallenge.Helpers.Monitor;

namespace CsharpCodeChallenge.Controllers
{
    public class TvShowController: ITvShowController
    {

        private ITvShowBusiness _TvShowBusiness = new TvShowBusiness();                
        public List<TvShowDto> getAll()
        {
            Monitor.printConsole("cargando...");
            List<TvShowDto> TvShowList = _TvShowBusiness.getAll();
            Monitor.printConsoleList(TvShowList);                

            return TvShowList;
        }
        public List<TvShowDto> getFavorite()
        {
            List<TvShowDto> TvShowList = _TvShowBusiness.getFavorite();
            if(TvShowList.Count > 0)
                Monitor.printConsoleList(TvShowList);
            else
                Monitor.printConsole("No hay favoritos");

            return TvShowList;
        }
        
    }
}
