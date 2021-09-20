using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
   public class WeatherDataModel
    {
        [Key]
        public int ID { get; set; }
        public string WeatherType { get; set; }
        public DateTime WDate { get; set; }
    }
}
