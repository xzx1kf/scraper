using HtmlAgilityPack;
using System;

public class Scraper
{
    public static void Main()
    {
        Scraper.lotteryScraper();
        /*
        string url = "http://www.goonersguide.com/numbers_spreadsheet.htm";

        HtmlWeb webGet = new HtmlWeb();
        var document = webGet.Load(url);

        var metaTags = document.DocumentNode.SelectNodes("/html[1]/body[1]/table[3]"); // //meta
        // /html[1]/body/table[3]/tr[4]/td/div[2]/table/tr[3]/td[1]
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
        */
    }

    public static void lotteryScraper()
    {
        string url = "http://www.bbc.co.uk/lottery/";

        HtmlWeb webGet = new HtmlWeb();
        var document = webGet.Load(url);

        var root = "//div[@class='draws-box draws-lotto']/ul[@class='draws'][1]/li";

        var balls = document.DocumentNode.SelectNodes(root);

        foreach (var ball in balls)
        {
            System.Console.WriteLine(ball.InnerText);
        }
    }
}
