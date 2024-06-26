﻿using System.ComponentModel.DataAnnotations;

namespace API.EntityFramework.Entities
{
    public abstract class EntityBase
    {        
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
