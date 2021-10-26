using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class MoodDataModel
    {
        [Key]
        public Guid ID { get; set; }
        public int uID { get; set; }
        public string MoodType { get; set; }
        public DateTime MDate { get; set; }
    }
}
