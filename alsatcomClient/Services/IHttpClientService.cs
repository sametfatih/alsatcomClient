namespace alsatcomClient.Services
{
    public interface IHttpClientService
    {
        Task<T> GetRequest<T>(string requestUri);
        Task<HttpResponseMessage> PostRequest<T>(T model, string uri);


    }
}
