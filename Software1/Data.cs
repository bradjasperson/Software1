using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public static class ApplicationData
    {
        public static List<Part> AllParts
        {
            get
            {
                return ApplicationData._allParts;
            }

        }
        private static List<Part> _allParts = new List<Part>();
    }
}
