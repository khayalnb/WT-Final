using WT.DAL.BaseEntity;

namespace WT.DAL.Models
{
    public class SocialNetwork:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
