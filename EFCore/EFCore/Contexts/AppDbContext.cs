﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCore.Models;

namespace EFCore.Contexts;

public class AppDbContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product>Products { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = AB108EF; Trusted_Connection = True; TrustServerCertificate = True");
        base.OnConfiguring(optionsBuilder);
    }
}
