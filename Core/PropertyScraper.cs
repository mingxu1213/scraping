using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Core
{
    public class PropertyScraper
    {
        //public async Task<PizzaResult> Pizza()
        public async Task<RealResult> RealE()
        {
            var url = @"https://services.realestate.com.au/services/listings/summaries/search?query={%22channel%22:%22buy%22,%22filters%22:{%22surroundingSuburbs%22:%22true%22,%22excludeTier2%22:%22true%22,%22geoPrecision%22:%22address%22,%22excludeAddressHidden%22:%22true%22},%22boundingBoxSearch%22:[-27.585273368200333,153.0308537590637,-27.57580178589247,153.07853270651242],%22pageSize%22:%22500%22}";
            //var url = @"https://pizza-20-api.prod.pizzahutaustralia.com.au/api/services/app/store/GetTradingStoresStates";
            //using (HttpClient client = new HttpClient())
            //{
            //    var response = await client.GetAsync(url);
            //    var json = await response.Content.ReadAsStringAsync();
            //    var result = JsonConvert.DeserializeObject<PizzaResult>(json);
            //    return result;
            //}
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36");
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RealResult>(json);
                return result;
            }
        }
    }
}
 