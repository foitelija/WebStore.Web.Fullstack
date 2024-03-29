﻿using Microsoft.EntityFrameworkCore;
using BlazorShop.Shared;
using System;
using System.Collections.Generic;

namespace BlazorShop.Server.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        //Creating initial values in the database
        //Создание начальный значений в базе данных
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", Url = "action-games", Icon = "https://i.ibb.co/s1pCNrL/action-games-24px.png" },
            new Category { Id = 2, Name = "Role-play", Url = "role-play-games", Icon = "https://i.ibb.co/rph11zV/rpg-games-24px.png" },
            new Category { Id = 3, Name = "Fight", Url = "fighting-games", Icon = "https://i.ibb.co/tbcPJTd/boxing-games-24px.png" },
            new Category { Id = 4, Name = "Race", Url = "racing-games", Icon = "https://i.ibb.co/vZ6mQXF/race-games-24px.png" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Call of Duty 4: Modern Warfare",
                    Description = " мультиплатформенная компьютерная игра в жанре шутера от первого лица, разработанная американской компанией Infinity Ward и изданная Activision. Игра является четвёртой в серии Call of Duty и первой в подсерии Modern Warfare; официально проект был анонсирован 26 мая 2007 года.",
                    Image = "https://upload.wikimedia.org/wikipedia/ru/2/29/Cod4.jpg",
                    DateCreated = new DateTime(2022, 1, 1),
                },
               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Title = "Half-Life 2",
                   Description = "Half-Life 2 Description",
                   Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                   DateCreated = new DateTime(2022, 1, 1),
               },
               new Product
               {
                   Id = 3,
                   CategoryId = 1,
                   Title = "Grand Theft Auto 5",
                   Description = "Rockstar Games",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/c/c8/GTAV_Official_Cover_Art.jpg",
                   DateCreated = new DateTime(2022, 1, 1),
               },
               new Product
               {
                   Id = 4,
                   CategoryId = 3,
                   Title = "Mortal Kombat X",
                   Description = "Мультиплатформенная компьютерная игра в жанре файтинг, разработанная компанией NetherRealm Studios для игровых платформ PlayStation 4, Xbox One и Microsoft Windows.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/thumb/3/34/Mortal_Kombat_X.jpg/800px-Mortal_Kombat_X.jpg",
                   DateCreated = new DateTime(2022, 1, 1),
               },
               new Product
               {
                   Id = 5,
                   CategoryId = 4,
                   Title = "The Crew 2",
                   Description = "Представляем новинку революционной серии игр The Crew! Насладитесь азартом и атмосферой американских моторных состязаний в потрясающем открытом мире The Crew 2.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/4/42/The_Crew_2_coverart.jpg",
                   DateCreated = new DateTime(2022, 1, 1),
               },
               new Product
               {
                   Id = 6,
                   CategoryId = 2,
                   Title = "World of Warcraft: Battle for Azeroth",
                   Description = "World of Warcraft: Battle for Azeroth — седьмой дополнение для одной из самых известных MMORPG, World of Warcraft.",
                   Image = "https://upload.wikimedia.org/wikipedia/ru/thumb/a/ae/World_of_Warcraft_Battle_for_Azeroth_Box_Shot.jpg/800px-World_of_Warcraft_Battle_for_Azeroth_Box_Shot.jpg",
                   DateCreated = new DateTime(2022, 1, 1),
               });

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Ключ активации" },
                new Edition { Id = 2, Name = "Gift-подарок" },
                new Edition { Id = 3, Name = "Аккаунт" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
               new ProductVariant
               {
                   ProductId = 1,
                   EditionId = 1,
                   Price = 9.99m,
                   OriginalPrice = 19.99m
               },

                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 1,
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },

                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 1,
                    Price = 7.99m,
                    OriginalPrice = 8.99m
                },

                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 11.09m,
                    OriginalPrice = 11.09m
                },

                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 5.99m,
                    OriginalPrice = 15.99m
                },

                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 35.99m,
                    OriginalPrice = 40.01m
                },

                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 7.99m,
                },

                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 5.19m,
                },

                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 2,
                    Price = 4.99m,
                },

                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 3,
                    Price = 5.99m,
                },

                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 3,
                    Price = 25.99m,
                }
                );
        }
    }
}
