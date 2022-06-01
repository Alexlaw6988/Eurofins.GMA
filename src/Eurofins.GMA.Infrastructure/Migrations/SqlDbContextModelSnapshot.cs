﻿using Eurofins.GMA.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Eurofins.GMA.Infrastructure.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    public class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Asset", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);


                b.Property<string>("AssetId")
                    .IsRequired()
                    .HasMaxLength(50);

                b.Property<string>("FileName")
                    .IsRequired()
                    .HasMaxLength(300);

                b.Property<string>("MimeType")
                    .IsRequired()
                    .HasMaxLength(300);
                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(100);
                b.Property<string>("Country")
                    .IsRequired()
                    .HasMaxLength(100);
                b.Property<string>("Description")
                    .HasMaxLength(300);
                b.Property<string>("CreatedBy")
                    .IsRequired()
                    .HasMaxLength(100);
                b.Property<DateTime>("CreatedDate")
                    .IsRequired();
                b.Property<string>("ModifiedBy")
                    .HasMaxLength(100)
                    .IsRequired();
                b.Property<DateTime>("ModifiedDate")
                    .IsRequired();
                b.HasKey("Id");
                b.ToTable("Assets");
            });
        }
    }
}
