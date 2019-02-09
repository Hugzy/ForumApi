using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class SimpleUser
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}