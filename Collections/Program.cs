using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net;

namespace WeatherScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Airports> myList = new List<Airports>()
            {
                new Airports {Name = "Coen Airport", Url = "http://www.bom.gov.au/fwo/IDQ60801/IDQ60801.94183.axf"},
                new Airports {Name = "Burketown Airport", Url = "http://www.bom.gov.au/fwo/IDQ60801/IDQ60801.94260.axf"},
                new Airports {Name = "Kununurra Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94216.axf"},
                new Airports {Name = "Wyndham Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95214.axf"},
                new Airports {Name = "Newman Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94317.axf"},
                new Airports {Name = "Onslow Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95305.axf"},
                new Airports {Name = "Roebourne Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94308.axf"},
                new Airports {Name = "Shark Bay Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95402.axf"},
                new Airports {Name = "Leonora Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94450.axf"},
                new Airports {Name = "Perth Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94610.axf"},
                new Airports {Name = "Busselton Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95611.axf"},
                new Airports {Name = "Albany Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94802.axf"},
                new Airports {Name = "Esperance Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95638.axf"},
                new Airports {Name = "Southern Cross Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95634.axf"},
                new Airports {Name = "Cunderdin Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95625.axf"},
                new Airports {Name = "Morawa Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94417.axf"},
                new Airports {Name = "Geraldton Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.94403.axf"},
                new Airports {Name = "Norseman Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95642.axf"},
                new Airports {Name = "Wiluna Airport", Url = "http://www.bom.gov.au/fwo/IDW60801/IDW60801.95439.axf"},
            };

            foreach (Airports airports in myList)
            {
                
            }

        }
    }

    class Airports
    {
        public string Name
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }
    }

    class Scrape
    {
        public string ScrapeWebpage(string Name, string Url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(Url);
            
        }
    }
}