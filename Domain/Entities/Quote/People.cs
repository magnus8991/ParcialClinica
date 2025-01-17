﻿using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class People : Entity<int>
    {
        public string Identification { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool State { get; set; }
        public string Photo { get; set; }

        public People(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public People()
        {

        }
    }
}
