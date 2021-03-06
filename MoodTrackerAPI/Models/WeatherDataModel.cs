using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
   public class WeatherDataModel
    {
        [Key]
        public Guid ID { get; set; }
        public int uID { get; set; }
        public string WeatherType { get; set; }
        public DateTime WDate { get; set; }
    }
}
