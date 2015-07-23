﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseSharp.Portable.Filters
{
    class FirebaseKeySorter : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int xint, yint;
            if (int.TryParse(x, out xint))
            {
                if (int.TryParse(y, out yint))
                {
                    return xint.CompareTo(yint);
                }

                return -1;
            }

            if (int.TryParse(y, out yint))
            {
                return 1;
            }

            return String.Compare(x, y, StringComparison.Ordinal);
        }
    }
}
