using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Works.Controllers.Base
{
    public class BaseController : Controller

    {
        private readonly string apiBaseUrl;
        private readonly HttpClient _httpClient; // HTTP requests is made using an instance of the HttpClient class.HttpClient class acts as a session to send HTTP Requests. It is a collection of settings applied to all requests executed by that instance.
        private readonly  IConfiguration configure; //The IConfiguration interface need to be injected as dependency in the Controller and then later used throughout the Controller.The IConfiguration interface is used to read Settings and Connection Strings from AppSettings.json file.


        public BaseController(IConfiguration configuration, HttpClient httpClient)//The IConfiguration interface need to be injected as dependency in the Controller and then later used throughout the Controller.The IConfiguration interface is used to read Settings and Connection Strings from AppSettings.json file.
        {
            configure = configuration;
            apiBaseUrl = configuration.GetValue<string>("APIBaseUrl");
            _httpClient = httpClient;
        }

       

        //public ActionResult Index()

        public async Task<HttpResponseMessage> PostAsync<T>(T entity, string endpoint) //endpoint(maa url kun format maa kasari janxa)
        {
            
                 StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json"); //content negotiation  // "application/json"
                _httpClient.BaseAddress = new Uri(apiBaseUrl);   //new URI maa k hunxa?
                 HttpResponseMessage Response = await _httpClient.PostAsync(endpoint, content);//endpoint , where does it point?        
                 return Response;
                            
        }
        //already  done by dai
        //Get garda matra Query String
        public async Task<T> GetAsync<T>(string relativePath, string queryString = "")
         {
           
            var uriBuilder = new UriBuilder(apiBaseUrl + relativePath);
            uriBuilder.Query = queryString;
            var response = await _httpClient.GetAsync(uriBuilder.Uri, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }
        //Delete maa no ID and Query string 
        //HttpCompletionOption is an enum with two possible values. It controls at what point
        //operations on HttpClient should be considered completed.
        public async Task<HttpResponseMessage> DeleteAsync(string relativePath)
        {
            var uriBuilder = new UriBuilder(apiBaseUrl + relativePath);

            return await _httpClient.DeleteAsync(uriBuilder.Uri);


        }
        public async Task<HttpResponseMessage> PutAsync<T>(T entity, string relativePath)
        {
            var uriBuilder = new UriBuilder(apiBaseUrl + relativePath);

            StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");  // "application/json"    
                                                                                                                                // var response = await _httpClient.PutAsync(uriBuilder.Uri,content /*HttpCompletionOption.ResponseHeadersRead*/);

            return await _httpClient.PutAsync(uriBuilder.Uri, content);



        }

        public async Task<HttpResponseMessage> PatchAsync<T>(T entity, string relativePath)
        {
            var uriBuilder = new UriBuilder(apiBaseUrl + relativePath);

            StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json"); //content negotiation  // "application/json"

            return await _httpClient.PatchAsync(uriBuilder.Uri, content);

        }
        // Not Sure Correct
        //public async Task<HttpResponseMessage> GetAll<T>(T entity, string relativePath)
        //{

        //    var uriBuilder = new UriBuilder(apiBaseUrl + relativePath);

        //    StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");  // "application/json"    
        //                                                                                                                        // var response = await _httpClient.PutAsync(uriBuilder.Uri,content /*HttpCompletionOption.ResponseHeadersRead*/);

        //    return await _httpClient.GetAsync(uriBuilder.Uri, content);
        //}


       




















    }
}
