using Time_Management.Server.Models.Constants;

namespace Time_Management.Server.Models.ViewModels
{    
    public class BaseRequest
    {
        public int PageNumber { get; set; } = CommonSetting.PageIndex;
        public int PageSize { get; set; } = CommonSetting.PageSize;
        public string SortBy { get; set; }
        public string SortOrder { get; set; } = CommonSetting.SortOrderDefault;
        public string Filter { get; set; }
    }
}
