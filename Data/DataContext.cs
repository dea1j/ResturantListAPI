using System;
using Microsoft.EntityFrameworkCore;
using ResturantListApi.Models;

namespace ResturantListApi.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<HotelReview> HotelReviews { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
    }
}

