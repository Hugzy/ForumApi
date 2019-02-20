using System;
using System.ComponentModel.DataAnnotations;
using ForumApi.Core.Models;

namespace ForumApi.Thread.Models
{
    public class Thread
    {
        [Key]
        public Guid Id { get; set; }
        public Forum.Models.Forum Forum { get; set; }
        public SimpleUser Author { get; set; }
        public string Title { get; set; }
    }
}