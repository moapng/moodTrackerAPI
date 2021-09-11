using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class NoteDataModel
    {
        [Key]
        public int ID { get; set; }
        public string Note { get; set; }
        public int NDate { get; set; }
    }
}
