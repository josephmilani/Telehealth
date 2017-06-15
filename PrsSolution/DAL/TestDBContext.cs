using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PrsSolution.Models;

namespace PrsSolution.DAL
{
    public class TestDbContext : DbContext
    {


        public TestDbContext() : base("TestConnection")
        {

        }

        public DbSet<Test> Test { get; set; }
    }
}