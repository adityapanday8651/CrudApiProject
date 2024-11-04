namespace CrudDomain.Dto
{
    public class ResponseModelDto
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }

        public static ResponseModelDto CreateResponseData(bool status, string message, object? data)
        {
            return new ResponseModelDto
            {
                Status = status,
                Message = message,
                Data = data
            };
        }
    }

}
