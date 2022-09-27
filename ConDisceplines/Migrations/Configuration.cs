namespace ConDisceplines.Migrations
{
    using ConDisceplines.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConDisceplines.DAL.DisceplineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConDisceplines.DAL.DisceplineContext context)
        {
             var disceplines = new List<Discepline>
            {
                new Discepline{ID=0, NameDiscepline="Math", Hours=44, Control=Control.Exam},
                new Discepline { ID = 1, NameDiscepline = "Rus", Hours = 55, Control = Control.Test },
                new Discepline { ID = 2, NameDiscepline = "Inf", Hours = 42, Control = Control.DifTest }
            };
            disceplines.ForEach(s => context.Disceplines.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
