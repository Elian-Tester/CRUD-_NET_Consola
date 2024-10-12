
using CsharpCodeChallenge.Dto;

namespace CsharpCodeChallenge.Helpers
{
    public class Monitor
    {
        public static void printConsoleList(List<TvShowDto> TvShowList)
        {
            foreach (TvShowDto item in TvShowList)
            {
                Console.WriteLine(item.id + $" {(item.favorite ? "*" : " ")} " + item.name);
            }
        }
        public static void printConsole(string resp)
        {
            Console.WriteLine(resp);
        }
    }
}
