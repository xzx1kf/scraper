using HtmlAgilityPack;

public class Scraper
{
    public static string ScreenScraper(string url)
    {
        return new System.Net.WebClient().DownloadString(url);
    }

    public static void Main()
    {
        string url = "http://www.4guysfromrolla.com";
//        string html = ScreenScraper("http://www.google.co.uk");
//        System.Console.WriteLine(html);

        HtmlWeb webGet = new HtmlWeb();
        var document = webGet.Load(url);

        var metaTags = document.DocumentNode.SelectNodes("//meta");

        if (metaTags != null)
        {
            foreach (var tag in metaTags)
            {
                if (tag.Attributes["NAME"] != null && tag.Attributes["CONTENT"] != null)
                {
                    System.Console.WriteLine(tag.Attributes["NAME"].Value + " : " + tag.Attributes["CONTENT"].Value);
                }
            }
        }
    }
}
