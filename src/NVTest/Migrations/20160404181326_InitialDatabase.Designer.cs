using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using NVTest.Models;

namespace NVTest.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20160404181326_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NVTest.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuestionNumber");

                    b.Property<string>("QuestionText");

                    b.Property<string>("firstChoice");

                    b.Property<bool>("isRelevant");

                    b.Property<short?>("nvChoice");

                    b.Property<string>("secondChoice");

                    b.HasKey("Id");
                });
        }
    }
}
