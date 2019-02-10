using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class Thread
    {
        [Key]
        public Guid id { get; set; }
        public Forum.Models.Forum Forum { get; set; }
        public SimpleUser author { get; set; }
        public string Title { get; set; }
    }
}