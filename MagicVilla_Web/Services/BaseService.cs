using System.Text;
using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse ResponseModel { get; set; }
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseService(IHttpClientFactory httpClientFactory)
        {
            this.ResponseModel = new();
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = _httpClientFactory.CreateClient("MagicVillaAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "aplication/json");
                message.RequestUri = new Uri(apiRequest.Url);
                if(apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                }
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                HttpResponseMessage apiResponse = null;
                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var APIResponse = JsonConvert.DeserializeObject<T>(apiContent);

                return APIResponse;
            }
            catch(Exception ex)
            {
                var dto = new APIResponse()
                {
                    IsSuccess = false,
                    ErrorMessages = new List<string>() { Convert.ToString(ex.Message) }
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponse = JsonConvert.DeserializeObject<T>(res);
                return apiResponse;
            }

        }
    }
}
