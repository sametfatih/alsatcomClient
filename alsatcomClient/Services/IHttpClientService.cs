namespace alsatcomClient.Services
{
    public interface IHttpClientService
    {
        Task<T> GetRequest<T>(string requestUri);
    
    }
}
