using Microsoft.EntityFrameworkCore;
using OnTrackAPI.Models;

using System;
namespace OnTrackAPI.Data
{
    public class ApiContext : DbContext
    {

        //DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {
        }
    }
}

