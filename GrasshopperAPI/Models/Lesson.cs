using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrasshopperAPI.Models
{
    public class Lesson
    {
        [Key, Column(Order = 0)]
        public int GrasshopperId { get; set; }
        [Key, Column(Order = 1)]
        public int SenseiId { get; set; }
        [Key, Column(Order = 2)]
        public DateTime MeetingTime { get; set; }
        public long Duration { get; set; }
    }
}
