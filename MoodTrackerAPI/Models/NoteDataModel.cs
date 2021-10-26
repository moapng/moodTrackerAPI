using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class NoteDataModel
    {
        [Key]
        public Guid ID { get; set; }
        public int uID { get; set; }
        public string Note { get; set; }
        public DateTime NDate { get; set; }
    }
}
