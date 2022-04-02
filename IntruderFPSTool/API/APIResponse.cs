namespace IntruderFPSTool.API
{
    public class APIResponse<TResponse>
    {
        public bool Success { get; init; }
        public string? Error { get; init; }
        public TResponse? Response { get; init; }

        public APIResponse(TResponse? response, string? error, bool success)
        {
            Response = response;
            Error = error;

            Success = success;
        }
    }
}
