
using CsharpCodeChallenge.Controllers;
using CsharpCodeChallenge.Helpers;

class Program
{
    static void Main(String[] args)
    {
        Appsettings.Init();
        ITvShowController ITvShowController = new TvShowController();
        ITvFavoritesController ITvFavoriteController = new TvFavoritesController();

        Console.WriteLine("Programas de TV");
        while (true)
        {
            string? input = Console.ReadLine();            
            switch (input)
            {
                case "list": ITvShowController.getAll(); break;
                case "favorites": ITvShowController.getFavorite(); break;
                default: ITvFavoriteController.ChangeStatusFavorite(input); break;
            }
            Console.WriteLine("");
        }
    }
}

