using ConDisceplines.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConDisceplines.DAL
{
    //Класс получает данные из бд
    public class DisceplineContext : DbContext
    {
        public DisceplineContext() : base("DisceplineContext")
        {

        }
        public DbSet<Discepline> Disceplines { get; set; }
    }
}