using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUID
{
    internal class generator
    {
        private string _UppercaseLetters = "ABCDEF";
        private string _Digits = "0123456789";
        private Random _Random = new Random();
        public void Run()
        {
            //  string pocet = Console.ReadLine();
            bool proceed = true;
            while (proceed)
            {
                int count = Utils.SafelyConvertToInt (Console.ReadLine());
                if (count > 0)
                {
                    Generate(count);
                }
                else
                {
                    proceed = false;
                }
            }
           
        }
        private void Generate(int count)
        {
            string source = "0123456789ABCDEF";
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                string result = Booo(source, r);
                Console.WriteLine(result);
            }


        }
        private string Booo(string source, Random r)
        {
            string result = string.Empty;
            for (int i = 0; i < 36; i++)
            {
                if (i == 8 || i == 13 || i == 18 || i == 23)
                {
                    result += "-";
                }
                else
                {
                    result += source[r.Next(source.Length)];
                }
            }

            return result;
        }

        //8D8AC610-566D-4EF0-9C22-186B2A5ED793
        public string Create(int pocet)
        {
            string password = string.Empty;
            string sourceChars = BuildSource(true, true);
            for (int i = 0; i < 36; i+=pocet)
            {
                password += sourceChars[_Random.Next(sourceChars.Length)];
            }
            return password;
        }
        private string BuildSource(bool Uppercase, bool Digits)
        {
         string result = string.Empty;
        if (Uppercase)
            { 
                result += _UppercaseLetters;
            }
        if (Digits)
            {
                result += _Digits;
            }
            return result;
        }
        
    }
}
