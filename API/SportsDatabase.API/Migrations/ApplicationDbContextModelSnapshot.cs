﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsDatabase.API.Data;

#nullable disable

namespace SportsDatabase.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportsDatabase.API.Models.Domain.GameLog", b =>
                {
                    b.Property<int>("GameLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameLogId"));

                    b.Property<int?>("AwayTeamHistoryId")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamScore")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePlayed")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeTeamHistoryId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamScore")
                        .HasColumnType("int");

                    b.Property<bool?>("IsAssociationGame")
                        .HasColumnType("bit");

                    b.Property<bool>("IsChampionshipGame")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsConferenceGame")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDivisionalGame")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLeagueGame")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNeutralSite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOvertime")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOvertimeTiebreaker")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPostSeasonGame")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTournamentGame")
                        .HasColumnType("bit");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.HasKey("GameLogId");

                    b.ToTable("GameLogs");
                });

            modelBuilder.Entity("SportsDatabase.API.Models.Domain.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CurrentTeamHistoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SportsDatabase.API.Models.Domain.TeamHistory", b =>
                {
                    b.Property<int>("TeamHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamHistoryId"));

                    b.Property<string>("Conference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParentTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeamCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamNickname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamHistoryId");

                    b.ToTable("TeamHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
