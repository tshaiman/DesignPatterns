using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public static class Utils
    {
        public static bool IsMatch(this Person p)
        {
            return p.Name.StartsWith("A", StringComparison.CurrentCultureIgnoreCase);
        }
    }

}
