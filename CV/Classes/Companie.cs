﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    public class Companie:LCS
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Practice { get; set; }
        public override string ToString()
        {
            return $@"{base.ToString()}
Start time : {Start.ToShortDateString()}
End time : {End.ToShortDateString()}
Work practice : {Practice}"; 
        }
    }
}
