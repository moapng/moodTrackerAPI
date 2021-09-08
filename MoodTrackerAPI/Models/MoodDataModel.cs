using System;
using System.Collections.Generic;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class MoodDataModel
    {
        public int ID { get; set; }
        public string MoodType { get; set; }
        public int MDate { get; set; }
    }
}
