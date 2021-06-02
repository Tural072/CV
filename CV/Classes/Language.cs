using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    public class Language:LCS
    {
        public string Level { get; set; }
        public override string ToString()
        {
            return $@"{base.ToString()}
Level : {Level}";
        }
    }
}
