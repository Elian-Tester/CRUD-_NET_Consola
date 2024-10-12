using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpCodeChallenge.DBModels;
using CsharpCodeChallenge.Dto;

namespace CsharpCodeChallenge.Business
{
    public interface ITvShowBusiness
    {
        List<TvShowDto> getAll();
        List<TvShowDto> getFavorite();        
        Task<Programs_TV?> GetTvShowById(int id);
    }
}
