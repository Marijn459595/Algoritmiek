using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Shininess_generator
{
    internal static class FindShinyValue
    {
        public static int Find(int TrainerID, int SecretID, uint PokemonID)
        {
            string trainerID = Converter.ConvertTID(TrainerID);
            string secretID = Converter.ConvertTID(SecretID);
            string pokemonID1 = Converter.ConvertPID(PokemonID)[0];
            string pokemonID2 = Converter.ConvertPID(PokemonID)[1];

            string bits = "";

            char[] bitsArray = new char[4];

            for(int i = 0; i < 16; i++)
            {
                bitsArray[0] = trainerID[i];
                bitsArray[1] = secretID[i];
                bitsArray[2] = pokemonID1[i];
                bitsArray[3] = pokemonID2[i];
                bits += CalculateXOR(bitsArray).ToString();
            }

            return Convert.ToInt32(bits, 2);
        }

        private static char CalculateXOR(char[] bits)
        {
            int count = 0;
            foreach (char bit in bits)
            {
                if (bit == '1')
                {
                    count++;
                }
            }
            if (count % 2 == 1)
            {
                return '1';
            }
            else
            {
                return '0';
            }
        }
    }
}
