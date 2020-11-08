namespace SPENGO.Domain.Models.ResponseModel.Shared
{
    public class ResponseModel<T>
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
