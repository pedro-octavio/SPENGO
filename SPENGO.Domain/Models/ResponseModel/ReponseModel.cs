namespace SPENGO.Domain.Models.ResponseModel.Shared
{
    public class ReponseModel<T>
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
