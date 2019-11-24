using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrtResponde.Models;

namespace OrtResponde.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OrtResponde.Models.Question> Question { get; set; }
        public DbSet<OrtResponde.Models.Answer> Answer { get; set; }
    }
}
