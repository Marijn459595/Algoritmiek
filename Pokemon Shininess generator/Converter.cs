using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Shininess_generator
{
    internal static class Converter
    {
        public static string ConvertTID(int value)
        {
            string binary = Convert.ToString(value, 2);
            while (binary.Length < 16)
            {
                binary = "0" + binary;
            }
            return binary;
        }
        
        public static string[] ConvertPID(uint pid)
        {
            string[] binaries = new string[2];
            string binary = Convert.ToString(pid, 2);
            while (binary.Length < 32)
            {
                binary = "0" + binary;
            }
            binaries[0] = binary.Substring(0, 16);
            binaries[1] = binary.Substring(16, 16);
            return binaries;
        }

        public static uint ConvertToDecimal(string binary)
        {
            uint pid = Convert.ToUInt32(binary, 2);
            return pid;
        }
    }
}
