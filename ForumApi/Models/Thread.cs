using System;

namespace ForumApi.Models
{
    public class Thread
    {
        public Guid id { get; set; }
        public Forum Forum { get; set; }
        public SimpleUser author { get; set; }
        public string Title { get; set; }
    }
}