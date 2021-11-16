using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoodTrackerAPI.Models
{
    public class HabitDataModel
    {
        [Key]
        public Guid ID { get; set; }
        public int uID { get; set; }
        public DateTime HDate { get; set; }
        public bool Teeth { get; set; }
        public bool Hair { get; set; }
        public bool Skincare { get; set; }
        public bool Plants { get; set; }
        public bool Gym { get; set; }
        public bool DailyCleaning { get; set; }
        public bool Meds { get; set; }
        public bool Pets { get; set; }


    }
}
