using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class Content
    {
        [Key]
        public Guid Id { get; set; }
        public string Text { get; set; }
        public long Characters { get; set; }
        
    }
}