using Assignment_2_EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_EntityFramework.Configuration
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Bouns).IsRequired();
            builder.Property(x => x.Salary).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.HourRate).IsRequired();
            builder.Property(x => x.Dept_Id).IsRequired();


        }
    }
}
