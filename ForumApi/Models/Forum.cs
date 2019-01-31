using ForumApi.Models.Sensitive;

namespace ForumApi.Models
{
    public class Forum
    {
        public string Title { get; set; }
        public UserBase Author { get; set; }
    }
}