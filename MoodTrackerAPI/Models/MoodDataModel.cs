using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class MoodDataModel
    {
        [Key]
        public int ID { get; set; }
        public string MoodType { get; set; }
        public DateTime MDate { get; set; }
    }
}
