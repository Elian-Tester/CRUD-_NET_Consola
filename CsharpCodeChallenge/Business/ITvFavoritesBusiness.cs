
namespace CsharpCodeChallenge.Business
{
    public interface ITvFavoritesBusiness
    {
        Task<string> ChangeStatusFavorite(int id);
    }
}
