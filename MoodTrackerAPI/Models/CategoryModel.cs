using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class CategoryModel
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
      
    }
}
