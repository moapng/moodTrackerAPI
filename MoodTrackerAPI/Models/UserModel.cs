using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MoodTrackerAPI.Models
{
    public class UserModel
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }


    }
}
