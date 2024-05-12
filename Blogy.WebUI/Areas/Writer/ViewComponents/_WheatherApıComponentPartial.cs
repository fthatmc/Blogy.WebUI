using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blogy.WebUI.Areas.Writer.ViewComponents
{
    public class _WheatherApıComponentPartial : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=bal%C4%B1kesir&days=7"),
                Headers =
    {
        { "X-RapidAPI-Key", "df4a14f685msh5ad17fc6cf3dbc8p13d803jsn0a6b0451f5f6" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                return View(values);
            }
        }
    }
}
