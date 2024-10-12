using CsharpCodeChallenge.Controllers;
using CsharpCodeChallenge.Helpers;
using Xunit;

namespace UnitTestXunit.Tests
{
    public class TvFavoritesControllerShould
    {
        ITvFavoritesController tvFavoritesController;
        public TvFavoritesControllerShould()
        {
            Appsettings.Init();
            tvFavoritesController = new TvFavoritesController();
        }

        [Theory]
        [InlineData("1",true)]
        [InlineData("2", true)]
        [InlineData("10", false)]
        [InlineData("favorito", false)]
        public async void UpdateFavorite(string id, bool expected)
        {
            var resp = await tvFavoritesController.ChangeStatusFavorite(id);
            bool isChange = resp == "Se agregó a favoritos" || resp == "Se eliminó de favoritos";

            Assert.Equal(isChange, expected);
        }
    }
}
