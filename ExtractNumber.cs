using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    public class ExtractNumber
    {
        public int extractnumber(string original)
        {
            string output = "";
            string new_output = "";

            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == '0' || original[i] == '1' || original[i] == '2' || original[i] == '3' ||
                    original[i] == '4' || original[i] == '5' || original[i] == '6' || original[i] == '7' ||
                    original[i] == '8' || original[i] == '9')
                {
                    output += original[i];
                }
            }


            for (int j = 0; j < output.Length; j++)
            {
                if (output[j] == '0' || output[j] == '1')
                {
                    new_output += CharToStr(output[j]);
                }
                else
                {
                    new_output += output[j];
                }
            }

           

            return StrToInt(new_output); ;


        }
        public int StrToInt(string str)
        {
            int response = 0;

            foreach (char c in str)
            {
                response *= 10;
                response += c - '0';
            }
            return response;
        }
        public string CharToStr(char Char)
        {
            string cString = new string(new char[] { Char });

            return cString;
        }
       
    }
}
