using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SmirnovMN.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (!string.IsNullOrEmpty(text))
            {
                char firstLetter = char.ToLower(text[0]);

                for (int i = 1; i < text.Length; i++)
                {
                    if (char.ToLower(text[i]) == firstLetter)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}