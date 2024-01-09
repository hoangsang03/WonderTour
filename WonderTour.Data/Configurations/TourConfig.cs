using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WonderTour.Data.Models;

namespace WonderTour.Data.Configurations
{
    public class TourConfig : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasMany(t => t.Users)
                .WithMany(u => u.Tours)
                .UsingEntity(
                "UserTour",
                l => l.HasOne(typeof(User)).WithMany().HasForeignKey("user_id"),
            r => r.HasOne(typeof(Tour)).WithMany().HasForeignKey("tour_id"));
        }
    }
}
