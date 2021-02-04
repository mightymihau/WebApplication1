﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Director
    {
        public int DirectorId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
