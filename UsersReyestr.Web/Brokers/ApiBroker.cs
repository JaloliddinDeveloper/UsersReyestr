using Microsoft.Extensions.Configuration;
using RESTFulSense.Clients;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UsersReyestr.Web.Brokers
{
    public partial class ApiBroker: IApiBroker
    {
        private readonly HttpClient httpClient;
        private readonly IRESTFulApiFactoryClient restfulApiFactoryClient;
        private readonly IConfiguration configuration;

        public ApiBroker(
            HttpClient httpClient,
            IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;

            this.restfulApiFactoryClient =
                GetRESTFulApiClient();
        }
        private async ValueTask<T> GetAsync<T>(string relativeUrl) =>
           await this.restfulApiFactoryClient.GetContentAsync<T>(relativeUrl);

        private IRESTFulApiFactoryClient GetRESTFulApiClient()
        {
            string apiBaseUrl =
                this.configuration.GetValue<string>("ApiSettings:BaseUrl");

            if (string.IsNullOrWhiteSpace(apiBaseUrl))
                throw new InvalidOperationException("API BaseUrl konfiguratsiyada topilmadi.");

            this.httpClient.BaseAddress = new Uri(apiBaseUrl);

            return new RESTFulApiFactoryClient(this.httpClient);
        }
    }
}
