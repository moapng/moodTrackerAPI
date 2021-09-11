using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BackEndMoodTracker.Models
{
    class WeatherDataModel
    {
        [Key]
        public int ID { get; set; }
        public string WeatherType { get; set; }
        public int WDate { get; set; }
    }
}
