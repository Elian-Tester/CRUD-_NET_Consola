using CsharpCodeChallenge.Controllers;
using CsharpCodeChallenge.Helpers;
using Xunit;

namespace UnitTestXunit.Tests
{
    public class TvShowControllerShould
    {
        ITvShowController tvShow;
        public TvShowControllerShould()
        {
            Appsettings.Init();
            tvShow = new TvShowController();
        }

        [Fact]
        public void GetShowsList()
        {            
            var resp = tvShow.getAll();

            Assert.True(resp.Count > 0);
        }
        [Fact]
        public void GetShowsFavoritesList()
        {
            var resp = tvShow.getFavorite();

            Assert.True(resp.Count > 0);
        }
    }
}
