using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class AppSetting:BaseEntity<int>
    {
        public string HotlineNumber { get; set; }
        public string MailAdress { get; set; }
        public string CompanyInfo { get; set; }
    }
}
