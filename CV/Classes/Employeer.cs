﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    public class Employeer:Human
    {
        public List<Vacancy> Vacancies { get; set; }
        public List<Cv> Cvs { get; set; }
        public override string ToString()
        {
            return $@"{base.ToString()}
Vacancies : {Vacancies}
";
        }
    }
}
