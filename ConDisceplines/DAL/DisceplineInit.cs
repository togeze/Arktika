using ConDisceplines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConDisceplines.DAL
{
    //Старая инициализация бд, новую смотреть в папке Миграций
    public class DisceplineInit : System.Data.Entity. DropCreateDatabaseIfModelChanges<DisceplineContext>
    {
        protected override void Seed(DisceplineContext context)
        {
            var disceplines = new List<Discepline>
            {
                new Discepline{ID=0, NameDiscepline="Math", Hours=44, Control=Control.Exam},
                new Discepline { ID = 1, NameDiscepline = "Rus", Hours = 55, Control = Control.Test },
                new Discepline { ID = 2, NameDiscepline = "Inf", Hours = 42, Control = Control.DifTest }
            };
            disceplines.ForEach(s => context.Disceplines.Add(s));
            context.SaveChanges();
        }
    }
}