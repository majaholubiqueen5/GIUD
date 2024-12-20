using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID
{
    internal class Utils
    {
        public static int SafelyConvertToInt(string x)
        {
            if (int.TryParse(x, out int result))
            {
                return result;
            }
            return 0;
        }
    }
}
