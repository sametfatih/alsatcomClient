namespace alsatcomClient.Core.Utilities.Reponses
{
    public interface IResponse
    {
        bool Success { get; }
        string Message { get; }
    }
}
