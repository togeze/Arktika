using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConDisceplines.Models
{
    public enum Control
    {
        Test, DifTest, Exam
    }
    public class Discepline
    {
        public int ID { get; set; }
        public string NameDiscepline { get; set; }
        
        public int Hours { get; set; }

        public Control? Control { get; set; }

    }
}