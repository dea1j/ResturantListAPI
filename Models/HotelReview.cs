using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantListApi.Models
{
    [Table("HotelReviews")]
    public class HotelReview
	{
        [Key]
        [Required]
        public int id { get; set; }
        public string author { get; set; }
        public string email { get; set; }
        public string body { get; set; }
        public int hotel_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        [ForeignKey("hotel_id")]
        public Hotel hotel { get; set; }
    }
}

