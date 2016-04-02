using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Teacher_Form
{
    class Utilities
    {
        static public bool NullOrEmpty(String s)
        {
            if (s.Trim().Equals("") || s == null)
                return true;
            else
                return false;
        }
    }
}
