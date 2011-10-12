public class Scraper
{
    public static string ScreenScraper(string url)
    {
        return new System.Net.WebClient().DownloadString(url);
    }

    public static void Main()
    {
        string html = ScreenScraper("http://www.google.co.uk");
        System.Console.WriteLine(html);
    }
}
