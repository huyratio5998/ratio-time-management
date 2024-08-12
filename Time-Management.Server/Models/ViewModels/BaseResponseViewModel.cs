namespace Time_Management.Server.Models.ViewModels
{    
    public class BaseResponseViewModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }        

        public BaseResponseViewModel() { }

        public BaseResponseViewModel(bool success, string message)
        {
            Success = success;
            Message = message;            
        }
    }
}
