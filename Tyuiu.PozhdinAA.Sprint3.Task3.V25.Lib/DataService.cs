using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PozhdinAA.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;

            foreach (char c in value)
            {
                if (c == 'u')
                {
                    count++;
                    if (count == 2)
                    {
                        break;
                    }
                }
            }
            return count;
        }
    }
}