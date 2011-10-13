using HtmlAgilityPack;
using System;

public class Scraper
{
    public static void Main()
    {
        string url = "http://www.goonersguide.com/numbers_spreadsheet.htm";

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
