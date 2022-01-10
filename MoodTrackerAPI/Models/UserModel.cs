using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        [Key]
        public string UserName { get; set; }
    }
}