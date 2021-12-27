using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveOdevi
{
    internal class UsAlma
    {
        public int UsAl(int taban, int us)
        {
            if (us == 0)
                return 1;
            else
                return taban * UsAl(taban, us - 1);
        }
    }
}
