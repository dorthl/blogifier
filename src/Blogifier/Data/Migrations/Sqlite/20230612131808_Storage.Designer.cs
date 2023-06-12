// <auto-generated />
using System;
using Blogifier.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blogifier.Data.Migrations.Sqlite
{
  [DbContext(typeof(SqliteDbContext))]
  [Migration("20230612131808_Storage")]
  partial class Storage
  {
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

      modelBuilder.Entity("Blogifier.Identity.UserInfo", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasMaxLength(128)
                      .HasColumnType("INTEGER");

            b.Property<int>("AccessFailedCount")
                      .HasColumnType("INTEGER");

            b.Property<string>("Avatar")
                      .HasMaxLength(1024)
                      .HasColumnType("TEXT");

            b.Property<string>("Bio")
                      .HasMaxLength(2048)
                      .HasColumnType("TEXT");

            b.Property<string>("ConcurrencyStamp")
                      .IsConcurrencyToken()
                      .HasMaxLength(64)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasColumnOrder(0)
                      .HasDefaultValueSql("datetime()");

            b.Property<string>("Email")
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<bool>("EmailConfirmed")
                      .HasColumnType("INTEGER");

            b.Property<string>("Gender")
                      .HasMaxLength(32)
                      .HasColumnType("TEXT");

            b.Property<bool>("LockoutEnabled")
                      .HasColumnType("INTEGER");

            b.Property<DateTimeOffset?>("LockoutEnd")
                      .HasColumnType("TEXT");

            b.Property<string>("NickName")
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<string>("NormalizedEmail")
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<string>("NormalizedUserName")
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<string>("PasswordHash")
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<string>("PhoneNumber")
                      .HasMaxLength(32)
                      .HasColumnType("TEXT");

            b.Property<bool>("PhoneNumberConfirmed")
                      .HasColumnType("INTEGER");

            b.Property<string>("SecurityStamp")
                      .HasMaxLength(32)
                      .HasColumnType("TEXT");

            b.Property<int>("State")
                      .HasColumnType("INTEGER");

            b.Property<bool>("TwoFactorEnabled")
                      .HasColumnType("INTEGER");

            b.Property<int>("Type")
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("TEXT")
                      .HasColumnOrder(1);

            b.Property<string>("UserName")
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.HasIndex("NormalizedEmail")
                      .HasDatabaseName("EmailIndex");

            b.HasIndex("NormalizedUserName")
                      .IsUnique()
                      .HasDatabaseName("UserNameIndex");

            b.ToTable("Users", (string)null);
          });

      modelBuilder.Entity("Blogifier.Newsletters.Newsletter", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasDefaultValueSql("datetime()");

            b.Property<int>("PostId")
                      .HasColumnType("INTEGER");

            b.Property<bool>("Success")
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.HasIndex("PostId");

            b.ToTable("Newsletters");
          });

      modelBuilder.Entity("Blogifier.Newsletters.Subscriber", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<string>("Country")
                      .HasMaxLength(120)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasDefaultValueSql("datetime()");

            b.Property<string>("Email")
                      .IsRequired()
                      .HasMaxLength(160)
                      .HasColumnType("TEXT");

            b.Property<string>("Ip")
                      .HasMaxLength(80)
                      .HasColumnType("TEXT");

            b.Property<string>("Region")
                      .HasMaxLength(120)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("Subscribers");
          });

      modelBuilder.Entity("Blogifier.Options.OptionInfo", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasDefaultValueSql("datetime()");

            b.Property<string>("Key")
                      .IsRequired()
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("TEXT");

            b.Property<string>("Value")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.HasIndex("Key")
                      .IsUnique();

            b.ToTable("Options", (string)null);
          });

      modelBuilder.Entity("Blogifier.Shared.Category", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<string>("Content")
                      .IsRequired()
                      .HasMaxLength(120)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasDefaultValueSql("datetime()");

            b.Property<string>("Description")
                      .HasMaxLength(255)
                      .HasColumnType("TEXT");

            b.HasKey("Id");

            b.ToTable("Categories");
          });

      modelBuilder.Entity("Blogifier.Shared.Post", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<string>("Content")
                      .IsRequired()
                      .HasColumnType("TEXT");

            b.Property<string>("Cover")
                      .HasMaxLength(160)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasDefaultValueSql("datetime()");

            b.Property<string>("Description")
                      .IsRequired()
                      .HasMaxLength(450)
                      .HasColumnType("TEXT");

            b.Property<int>("PostType")
                      .HasColumnType("INTEGER");

            b.Property<DateTime?>("PublishedAt")
                      .HasColumnType("TEXT");

            b.Property<string>("Slug")
                      .IsRequired()
                      .HasMaxLength(160)
                      .HasColumnType("TEXT");

            b.Property<int>("State")
                      .HasColumnType("INTEGER");

            b.Property<string>("Title")
                      .IsRequired()
                      .HasMaxLength(160)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("UpdatedAt")
                      .HasColumnType("TEXT");

            b.Property<int>("UserId")
                      .HasColumnType("INTEGER");

            b.Property<int>("Views")
                      .HasColumnType("INTEGER");

            b.HasKey("Id");

            b.HasIndex("Slug")
                      .IsUnique();

            b.HasIndex("UserId");

            b.ToTable("Posts", (string)null);
          });

      modelBuilder.Entity("Blogifier.Shared.PostCategory", b =>
          {
            b.Property<int>("PostId")
                      .HasColumnType("INTEGER");

            b.Property<int>("CategoryId")
                      .HasColumnType("INTEGER");

            b.HasKey("PostId", "CategoryId");

            b.HasIndex("CategoryId");

            b.ToTable("PostCategories", (string)null);
          });

      modelBuilder.Entity("Blogifier.Storages.Storage", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<string>("ContentType")
                      .HasMaxLength(128)
                      .HasColumnType("TEXT");

            b.Property<DateTime>("CreatedAt")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("TEXT")
                      .HasDefaultValueSql("datetime()");

            b.Property<long>("Length")
                      .HasColumnType("INTEGER");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasMaxLength(1024)
                      .HasColumnType("TEXT");

            b.Property<string>("Path")
                      .IsRequired()
                      .HasMaxLength(2048)
                      .HasColumnType("TEXT");

            b.Property<string>("Slug")
                      .IsRequired()
                      .HasMaxLength(2048)
                      .HasColumnType("TEXT");

            b.Property<int>("Type")
                      .HasColumnType("INTEGER");

            b.Property<DateTime>("UploadAt")
                      .HasColumnType("TEXT");

            b.Property<int>("UserId")
                      .HasColumnType("INTEGER");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("Storages", (string)null);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
          {
            b.Property<int>("Id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("INTEGER");

            b.Property<string>("ClaimType")
                      .HasMaxLength(16)
                      .HasColumnType("TEXT");

            b.Property<string>("ClaimValue")
                      .HasMaxLength(256)
                      .HasColumnType("TEXT");

            b.Property<int>("UserId")
                      .HasColumnType("INTEGER");

            b.HasKey("Id");

            b.HasIndex("UserId");

            b.ToTable("UserClaim", (string)null);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
          {
            b.Property<string>("LoginProvider")
                      .HasColumnType("TEXT");

            b.Property<string>("ProviderKey")
                      .HasColumnType("TEXT");

            b.Property<string>("ProviderDisplayName")
                      .HasMaxLength(128)
                      .HasColumnType("TEXT");

            b.Property<int>("UserId")
                      .HasColumnType("INTEGER");

            b.HasKey("LoginProvider", "ProviderKey");

            b.HasIndex("UserId");

            b.ToTable("UserLogin", (string)null);
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
          {
            b.Property<int>("UserId")
                      .HasColumnType("INTEGER");

            b.Property<string>("LoginProvider")
                      .HasColumnType("TEXT");

            b.Property<string>("Name")
                      .HasColumnType("TEXT");

            b.Property<string>("Value")
                      .HasMaxLength(1024)
                      .HasColumnType("TEXT");

            b.HasKey("UserId", "LoginProvider", "Name");

            b.ToTable("UserToken", (string)null);
          });

      modelBuilder.Entity("Blogifier.Newsletters.Newsletter", b =>
          {
            b.HasOne("Blogifier.Shared.Post", "Post")
                      .WithMany()
                      .HasForeignKey("PostId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("Post");
          });

      modelBuilder.Entity("Blogifier.Shared.Post", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", "User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("User");
          });

      modelBuilder.Entity("Blogifier.Shared.PostCategory", b =>
          {
            b.HasOne("Blogifier.Shared.Category", "Category")
                      .WithMany("PostCategories")
                      .HasForeignKey("CategoryId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.HasOne("Blogifier.Shared.Post", "Post")
                      .WithMany("PostCategories")
                      .HasForeignKey("PostId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("Category");

            b.Navigation("Post");
          });

      modelBuilder.Entity("Blogifier.Storages.Storage", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", "User")
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();

            b.Navigation("User");
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
          {
            b.HasOne("Blogifier.Identity.UserInfo", null)
                      .WithMany()
                      .HasForeignKey("UserId")
                      .OnDelete(DeleteBehavior.Cascade)
                      .IsRequired();
          });

      modelBuilder.Entity("Blogifier.Shared.Category", b =>
          {
            b.Navigation("PostCategories");
          });

      modelBuilder.Entity("Blogifier.Shared.Post", b =>
          {
            b.Navigation("PostCategories");
          });
#pragma warning restore 612, 618
    }
  }
}
