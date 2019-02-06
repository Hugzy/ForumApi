using System;
using System.ComponentModel.DataAnnotations;

namespace ForumApi.Models
{
    public class SimpleUser
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}