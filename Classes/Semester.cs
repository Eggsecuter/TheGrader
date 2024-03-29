﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrader
{ 
    public class Semester
    {
        public string Name { get; set; } 
        public DateTime StartDate { get; set; }
        public bool Completed { get; set; } 

        public List<Fach> Faecher { get; set; }

        public Semester(string name, DateTime startDate, bool completed)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Completed = completed;
            this.Faecher = new List<Fach>();
        }
        //needed for xml serialization
        public Semester()
        {

        }
    }
}

