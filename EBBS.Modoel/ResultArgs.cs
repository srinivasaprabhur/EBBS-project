namespace RestAPI.Model
{
    public class ResultArgs
    {
        public Int64 StatusCode { get; set; }
        public string? StatusMessage { get; set; }
        public object? ResultData { get; set; } 

    }

}
