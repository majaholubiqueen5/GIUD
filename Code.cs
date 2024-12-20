using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GUID
{
    internal class Code
    {
        public void Run()
        {
            generator generator = new generator();
            bool proceed = true;
            while (proceed)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    int length = Utils.SafelyConvertToInt(input);
                    if (length != int.MinValue)
                    {
                        Console.WriteLine(generator.Create(32));
                    }
                    else
                    {
                        proceed = false;
                    }

                }
            }
        }
    }
}
