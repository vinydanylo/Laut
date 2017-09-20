using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laut.Mobile.Models;
using System.Xml.Linq;

namespace Laut.Mobile.Services
{
    public class ApiService : IApiService
    {
        public async Task<List<News>> GetNews()
        {
            XDocument feedXML = XDocument.Load("https://jonathanbraga.github.io/feed.xml");

            var news = new List<News>();
            var feeds = from feed in feedXML.Descendants("entry")
                        select new
                        {
                           Title = feed.Element("title").Value
                        };
            return news;
        }
    }
}
