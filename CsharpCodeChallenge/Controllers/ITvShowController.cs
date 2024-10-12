using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpCodeChallenge.Dto;

namespace CsharpCodeChallenge.Controllers
{
    public interface ITvShowController
    {
        List<TvShowDto> getAll();
        List<TvShowDto> getFavorite();        
    }
}
