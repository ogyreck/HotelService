﻿using Duende.IdentityServer.EntityFramework.Options;
using HotelService.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HotelService.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
            
        }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<House> Houses { get; set; }

        public DbSet<Owner> Owners { get; set; }
    }
}