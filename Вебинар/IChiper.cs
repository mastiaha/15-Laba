using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вебинар
{
    interface IChiper
    {
        string EnCode(string s);
        string DeCode(string s);
    }
    class AChiper : IChiper
    {
        public string DeCode(string s)
        {
            string result = " ";
            foreach (char c in s)
            {
                if (c >= 'B' && c <= 'Z')
                {
                    result += (char)((int)c - 1);
                }
                else if (c == 'A')
                {
                    result += 'Z';
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public string EnCode(string s)
        {
            string result = " ";
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Y')
                {
                    result += (char)((int)c + 1);
                }
                else if (c == 'Z')
                {
                    result += 'A';
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
