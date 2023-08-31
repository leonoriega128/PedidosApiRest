using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CourseCode)
                .IsRequired();
            builder.Property(x => x.DischargeDate)
                .HasMaxLength(100);
            builder.Property(x => x.State)
                .IsRequired();
            builder.Property(x => x.NumberGraduates);
            builder.Property(x => x.DeliveryDate);
            builder.Property(x => x.DeliveryMedium);
            builder.Property(x => x.Seller);
            builder.Property(x => x.CollegeLevel);
            builder.Property(x => x.CollegeName);
            builder.Property(x => x.CollegeCourse);
            builder.Property(x => x.SchoolLocation);
            builder.Property(x => x.Commission);
            builder.Property(x => x.Total);


        }
    }
}
