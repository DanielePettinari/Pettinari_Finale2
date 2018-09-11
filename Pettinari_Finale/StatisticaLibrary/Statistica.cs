using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticaLibrary
{
    public class Statistica
    {
        public static bool IsPositivo(int num)
        {
            bool positivo = false;
            if (num > 0)
            {
                positivo = true;
            }

            return positivo;
        }

        public static int ContaPositivi(int[] Numeri)
        {
            int NumPositivi = 0;

            for (int i = 0; i < Numeri.Length; i++)

            {
                if (Numeri[i] > 0)
                {
                    NumPositivi++;
                }

            }
            return NumPositivi;
        }

        public static int[] Positivi(int[] Positivi2, int[] Positivi3)
        {
            for (int i = 0; i < Positivi2.Length; i++)

            {
                if (Positivi2[i] < 0)
                {
                    Positivi3[i] = Positivi2[i];
                }

            }
            return Positivi3;
        }
}
