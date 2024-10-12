using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpCodeChallenge.DBConnections;
using CsharpCodeChallenge.DBModels;
using CsharpCodeChallenge.Dto;

namespace CsharpCodeChallenge.Persistence.Query
{
    public class QTvShow
    {
        public List<TvShowDto> GetAll(int idUser) {
            using(ContextDb dbc = new ContextDb())
            {
                List<TvShowDto> shows =  (from a in dbc.Programs_TVs
                                                           join b in dbc.Favorite_TVs
                                                           on a.id equals b.idProgram_TV into ab
                                                           from b in ab.DefaultIfEmpty()
                                                           select new TvShowDto
                                                           {
                                                               id = a.id,
                                                               name = a.name,
                                                               favorite = b != null && b.idUser == idUser && Convert.ToBoolean(b.isFavorite)
                                                           }).ToList();
                return shows;
            }
        }

        public List<TvShowDto> GetFavorites(int idUser) {

            using (ContextDb dbc = new ContextDb())
            {
                List<TvShowDto> shows = (from a in dbc.Programs_TVs
                                         join b in dbc.Favorite_TVs
                                         on a.id equals b.idProgram_TV
                                         where b.idUser == idUser && b.isFavorite == 1
                                         select new TvShowDto { 
                                             id = a.id, 
                                             name = a.name, 
                                             favorite = true 
                                         }).OrderBy(x => x.id).ToList();
                return shows;
            }
        }        

        public Programs_TV? getTvProgramById(int id)
        {
            using(ContextDb dbc = new ContextDb())
            {
                Programs_TV? program = dbc.Programs_TVs.Find(id);
                return program;
            }
        }
    }
}
