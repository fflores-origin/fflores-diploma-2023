using PD.Services.Interfaces;

namespace PD.Services
{
    public class FacturacionService : IFacturacionService
    {
        private readonly HttpClient httpClient;

        public FacturacionService()
        {
            httpClient = new HttpClient();
        }

        public string GetLastNumber()
        {
            //var task = httpClient.GetAsync("url");

            //Task.WaitAll(task);

            Task.Delay(1000);

            return "0001-00000001";
        }
    }
}