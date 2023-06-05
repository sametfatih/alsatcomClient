namespace alsatcomClient.Core.Utilities.Reponses
{
    public interface IDataResponse<T> : IResponse
    {
        T Data { get; }
    }
}
