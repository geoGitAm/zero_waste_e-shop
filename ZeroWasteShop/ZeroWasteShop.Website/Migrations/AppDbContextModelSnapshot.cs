﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZeroWasteShop.Website.Models;

namespace ZeroWasteShop.Website.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ZeroWasteShop.Website.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Body Care Product"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Household Cleaning Product"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Product Made Of Recycled Materials"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Trash Reducing Product"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Vacuum Flask Product"
                        });
                });

            modelBuilder.Entity("ZeroWasteShop.Website.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "The soap does not contain palm or coconut oils. A very gentle skin-softening soap.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\bodycare1_thumb.jpg",
                            ImageUrl = "\\images\\bodycare1.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Body Soap",
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "A bamboo toothbrush with charcoal bristles, giving the product strong antibacterial properties, cleaning plaque and intensive whitening.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\bodycare2_thumb.jpg",
                            ImageUrl = "\\images\\bodycare2.png",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Bamboo Tooth Brush",
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "Helps keep your cosmetic products last longer, perfect for travel.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\bodycare3_thumb.jpg",
                            ImageUrl = "\\images\\bodycare3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Jar for cosmetics",
                            Price = 1.99m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Laundry soap with mustard and soda.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\cleaning1_thumb.jpg",
                            ImageUrl = "\\images\\cleaning1.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Laundry Soap",
                            Price = 0.59m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Description = "Helps keep your soap fresh longer.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\cleaning2_thumb.jpg",
                            ImageUrl = "\\images\\cleaning2.png",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Wooden Soap Dish",
                            Price = 2.59m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Description = "Helps to clean the house quickly, efficiently, without much effort, while not using any cleaning agents.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\cleaning3_thumb.jpg",
                            ImageUrl = "\\images\\cleaning3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Cleaning Kit",
                            Price = 12.59m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Description = "Eco-friendly ballpoint pen made from recycled milk and juice bags, soft and pleasant to the touch. As a result of the processing of this packaging, polyaluminium and cellulose are obtained, from which handles and cases for them are subsequently created.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\recycled1_thumb.jpg",
                            ImageUrl = "\\images\\recycled1.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Recycled Ballpoint Pen",
                            Price = 0.50m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            Description = "Handcrafted from recycled paper and cardboard.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\recycled2_thumb.jpg",
                            ImageUrl = "\\images\\recycled2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Recycled Postcard",
                            Price = 4.00m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            Description = "Eco toy rope for dogs made of hemp, ball with two ribs.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\recycled3_thumb.jpg",
                            ImageUrl = "\\images\\recycled3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Eco Toy For Dogs",
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            Description = "The glass is made of food grade silicone, the lid and sleeve are made of polypropylene. Suitable for hot and cold drinks (0 to 100 ° C), dishwasher safe (easy to disassemble), microwave use after removing the sleeve and lid.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\trashreducing1_thumb.jpg",
                            ImageUrl = "\\images\\trashreducing1.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Foldable Silicone Cup",
                            Price = 9.00m
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            Description = "Inexpensive and reliable bag clamps made of completely redesigned tetrapack. As a result of the processing of this packaging, polyaluminium and cellulose are obtained, from which clamps are subsequently created. Eco-friendly and versatile - they will definitely find use in your kitchen!",
                            ImageThumbnailUrl = "\\images\\thumbnails\\trashreducing2_thumb.jpg",
                            ImageUrl = "\\images\\trashreducing2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Bag Clip",
                            Price = 0.99m
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            Description = "The set consists of a knife with a magnetic handle, a fork and a spoon, is compact and has a special silicone cover to keep everything clean before and after use.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\trashreducing3_thumb.jpg",
                            ImageUrl = "\\images\\trashreducing3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Cutlery Set",
                            Price = 14.00m
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 5,
                            Description = "Used to keep drinks warm. The average temperature retention time is 5-7 hours. Do not overfill the thermos, always leave a gap of about 2 centimeters between the liquid and the stopper. Avoid sudden temperature changes. Rinse the thermos with warm water before first use. Service life is not limited.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\vacuumflask1_thumb.jpg",
                            ImageUrl = "\\images\\vacuumflask1.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Metal Flask (0.5L)",
                            Price = 12.00m
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 5,
                            Description = "Used to keep drinks warm. The average temperature retention time is 5-7 hours. Do not overfill the thermos, always leave a gap of about 2 centimeters between the liquid and the stopper. Avoid sudden temperature changes. Rinse the thermos with warm water before first use. Service life is not limited.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\vacuumflask2_thumb.jpg",
                            ImageUrl = "\\images\\vacuumflask2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Metal Flask (0.75L)",
                            Price = 16.59m
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 5,
                            Description = "This thermos is not only beautiful, but also incredibly functional. Unique modern design. Stylish matte colors. Ideal for hot / cold drinks, noodles, soups or rice. Double wall stainless steel. Up to 12/24 hours of cold. 100% sealed.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\vacuumflask3_thumb.jpg",
                            ImageUrl = "\\images\\vacuumflask3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Coffee Flask (0.5L)",
                            Price = 10.00m
                        });
                });

            modelBuilder.Entity("ZeroWasteShop.Website.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ZeroWasteShop.Website.Models.Product", b =>
                {
                    b.HasOne("ZeroWasteShop.Website.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ZeroWasteShop.Website.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ZeroWasteShop.Website.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ZeroWasteShop.Website.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
