using CsharpCodeChallenge.Business;
using CsharpCodeChallenge.DBConnections;
using CsharpCodeChallenge.DBModels;
using CsharpCodeChallenge.Dto;
using CsharpCodeChallenge.Persistence.Query;
using CsharpCodeChallenge.Persistence.Repository;

namespace CsharpCodeChallenge.Bussiness
{
    public class TvShowBusiness: ITvShowBusiness
    {
        private IRepository<Programs_TV> _repositoryProgram = new Repository<Programs_TV>(new ContextDb());
        QTvShow qTvShow = new QTvShow();

        public List<TvShowDto> getAll()
        {
            return qTvShow.GetAll(1);
        }
        public List<TvShowDto> getFavorite()
        {            
            return qTvShow.GetFavorites(1);
        }        
        public async Task<Programs_TV?> GetTvShowById(int id)
        {
            return await _repositoryProgram.GetById(id);
        }
    }
}
