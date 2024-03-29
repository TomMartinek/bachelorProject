﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorProject.Models
{
    // třída pro rozšiřování třídy "ModelBuilder"
    public static class ModelBuilerExtensions
    {
        // metoda pro naplnění databáze testovacími daty, tato metoda však není využívána
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Tomáš Martínek",
                    Email = "tomasmar7@seznam.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Tereza Hartová",
                    Email = "terysek@seznam.com"
                }
            );
        }
    }
}
