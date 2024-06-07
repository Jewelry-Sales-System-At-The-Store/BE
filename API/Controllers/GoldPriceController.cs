using BusinessObjects.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldPriceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };
            var httpClient = new HttpClient(handler);
            var response = await httpClient.GetAsync("https://sjc.com.vn/xml/tygiavang.xml");
            var html = await response.Content.ReadAsStringAsync();

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var updateTime = doc.DocumentNode.SelectSingleNode("//ratelist")?.Attributes["updated"]?.Value;

            var cities = doc.DocumentNode.SelectNodes("//ratelist/city");
            var goldPrices = new List<GoldPrice>();

            if (cities != null)
            {
                foreach (var cityNode in cities)
                {
                    var city = cityNode.Attributes["name"]?.Value;
                    var items = cityNode.SelectNodes("item");

                    if (items != null)
                    {
                        foreach (var itemNode in items)
                        {
                            var buyPrice = itemNode.Attributes["buy"]?.Value;
                            var sellPrice = itemNode.Attributes["sell"]?.Value;
                            var type = itemNode.Attributes["type"]?.Value;

                            goldPrices.Add(new GoldPrice
                            {
                                City = city,
                                BuyPrice = float.Parse(buyPrice),
                                SellPrice = float.Parse(sellPrice),
                                Type = type,
                            });
                        }
                    }
                }
            }

            return Ok(new { UpdateTime = updateTime, GoldPrices = goldPrices });
        }
    }
}
